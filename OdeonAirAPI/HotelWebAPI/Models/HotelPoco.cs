using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelWebAPI.Models
{
    public class HotelPoco
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public int HotelRoomNumber { get; set; }
        public bool IsLogin { get; set; }
    }
}