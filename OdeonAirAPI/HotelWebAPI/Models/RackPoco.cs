using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelWebAPI.Models
{
    public class RackPoco
    {
        public int ReservationId { get; set; }
        public string Room_no { get; set; }
        public string Room_color { get; set; }
        public string Room_status_name { get; set; }
        public string Room_type_name { get; set; }
        public string In_name { get; set; }
        public DateTime? In_from_date { get; set; }
        public DateTime? In_to_date { get; set; }
        public string In_agency { get; set; }
        public decimal? In_house_balance { get; set; }
    }
}