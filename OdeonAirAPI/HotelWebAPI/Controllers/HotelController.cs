using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using HotelWebAPI.Models;
using System.Web.Mvc;
using System.Web;
using HotelWebAPI.LINQ;

namespace HotelWebAPI.Controllers
{
    public class HotelController : ApiController
    {
        private dbLINQDataContext db = new dbLINQDataContext();
        public HotelPoco GetHotelLogin(int otel_id)
        {
            var hoteldb = db.Hotel.FirstOrDefault(e => e.Id == otel_id);
            if (hoteldb == null)
                return new HotelPoco { IsLogin = false };
            else
            {
                HotelPoco hotelpoco = new HotelPoco
                {
                    IsLogin = true,
                    HotelId=hoteldb.Id,
                    HotelName = hoteldb.Name                  
                };              
                return hotelpoco;
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CustomerExists(int id)
        {
            return db.Hotel.Count(e => e.Id == id) > 0;
        }
    }
}
