using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web;
//using System.Web.Mvc;


namespace HotDesk.Models
{
    public class Workplaces
    {
        public int WorkplaceId { get; set; }
        public string WorkplaceNumber { get; set; }
        public string WorkplaceImage { get; set; }
        public int BookingStatusId { get; set; }
        //public HttpPostedFileBase Image { get; set; }
        public string Description { get; set; }
        public List<SelectListItem> ListOfBookingStatus { get; set; }
        public List<SelectListItem> ListOfRoomType { get; set; }
    }
}
