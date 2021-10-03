using HotDesk.Models;
using System.Collections.Generic;

namespace HotDesk.ViewModels
{
    public class ReservationViewModel
    {
        public IEnumerable<Reservation> Reservations { get; set; }
        public Reservation Reservation { get; set; }
        public IEnumerable<Device> AllDevices { get; set; }
    }
}
