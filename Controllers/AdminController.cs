using HotDesk.Models;
using HotDesk.Models.Services;
using HotDesk.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace HotDesk.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService) => _adminService = adminService;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }     

        #region Workplace Actions
        [HttpGet]
        public IActionResult Workplaces()
        {
            var model = new WorkplacesViewModel()
            {
                Workplaces = _adminService.GetAll<Workplace>()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Workplaces(WorkplacesViewModel viewModel, int workplaceId)
        {
            if (ModelState.IsValid)
            {
                var newWorkplace = new Workplace
                {
                    Description = viewModel.Description,
                    HasDesktop = viewModel.HasDesktop
                };
                _adminService.Add(newWorkplace);
            }

            if (workplaceId != 0)
            {
                var workplaceToRemove = _adminService.Get<Workplace>(w => w.Id == workplaceId);
                _adminService.Remove(workplaceToRemove);
            }

            viewModel.Workplaces = _adminService.GetAll<Workplace>();
            return View(viewModel);
        }
        #endregion

        #region Device Actions
        [HttpGet]
        public IActionResult Devices()
        {
            var model = new DevicesViewModel()
            {
                Devices = _adminService.GetAll<Device>()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Devices(DevicesViewModel viewModel, int deviceId)
        {
            if (ModelState.IsValid)
            {
                var newDevice = new Device
                {
                    Name = viewModel.DeviceName
                };

                _adminService.Add(newDevice);
            }

            if (deviceId != 0)
            {
                var deviceToRemove = _adminService.Get<Device>(d => d.Id == deviceId);
                _adminService.Remove(deviceToRemove);
            }

            viewModel.Devices = _adminService.GetAll<Device>();
            return View(viewModel);
        }
        #endregion

        #region Reservation Actions
        [HttpGet]
        public IActionResult Reservations()
        {
            var model = _adminService.GetAll<Reservation>();
            return View(model);
        }

        [HttpPost]
        public IActionResult Reservations(int reservationId, params int[] deviceIds)
        {
            if (reservationId != 0)
            {
                var reservationToModify = _adminService.Get<Reservation>(r => r.Id == reservationId);
                reservationToModify.Devices = _adminService.UpdateDevices(deviceIds);
            }

            var model = _adminService.GetAll<Reservation>();
            return View(model);
        }

        [HttpPost]
        public IActionResult EditReservation(int reservationId)
        {
            var viewModel = new ReservationViewModel
            {
                Reservation = _adminService.Get<Reservation>(r => r.Id == reservationId),
                AllDevices = _adminService.GetAll<Device>()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult CancelReservation(ReservationViewModel viewModel, int reservationId)
        {
            if (reservationId != 0)
            {
                var reservationToRemove = _adminService.Get<Reservation>(r => r.Id == reservationId);
                _adminService.Remove(reservationToRemove);
            }

            viewModel.Reservations = _adminService.GetAll<Reservation>();
            return View(viewModel);
        }
        #endregion
    }
}
