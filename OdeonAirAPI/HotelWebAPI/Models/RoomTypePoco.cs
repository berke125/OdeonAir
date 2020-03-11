using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelWebAPI.Models
{
    public class RoomTypePoco
    {
        public int Room_type_id { get; set; }
        public int Hotel_id { get; set; }
        public int? Number_In_Hotel { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Display_Order { get;set; }
    }
}