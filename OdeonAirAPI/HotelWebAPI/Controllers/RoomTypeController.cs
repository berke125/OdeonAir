using HotelWebAPI.LINQ;
using HotelWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotelWebAPI.Controllers
{
    public class RoomTypeController : ApiController
    {
        private dbLINQDataContext db = new dbLINQDataContext();
        public List<RoomTypePoco> GetRoomTypes(int otelId)
        {
            List<RoomType> roomtypelist = (from x in db.RoomType
                                           where x.HotelId == otelId 
                                           select x
                                           ).ToList();
            List<RoomTypePoco> roomTypePocoList = new List<RoomTypePoco>();
            foreach(var roomtypedb in roomtypelist)
            {
                RoomTypePoco room_type_poco = new RoomTypePoco
                {
                    Room_type_id = roomtypedb.Id,
                    Hotel_id=roomtypedb.HotelId,
                    Number_In_Hotel=roomtypedb.NumberInHotel,
                    Name=roomtypedb.Name,
                    Description=roomtypedb.Description,
                    Display_Order=roomtypedb.DisplayOrder

                };
                roomTypePocoList.Add(room_type_poco);
            }
            return roomTypePocoList;
        }
    }
}
