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
    public class RackController : ApiController
    {
        private dbLINQDataContext db = new dbLINQDataContext();
        public List<RackPoco> GetRack(int Otel_Id)
        {
            List<_RACKVIEW> rackdblist = (from x in db._RACKVIEW
                                          
                                          orderby x.RoomNo
                                          where x.HotelId==Otel_Id
                                          select x).ToList();

            List<RackPoco> racklistPoco = new List<RackPoco>();
            foreach (var rackdb in rackdblist)
            {
                RackPoco rackPoco = new RackPoco
                {
                    
                    Room_no = rackdb.RoomNo,
                    Room_color = rackdb.RoomColor,
                    Room_status_name= rackdb.RoomStatusName,
                    Room_type_name = rackdb.RoomTypeName,
                    In_name=rackdb.InName,
                    In_from_date = rackdb.InFromdate,
                    In_to_date = rackdb.InTodate,
                    In_agency = rackdb.InAgency,
                    In_house_balance=rackdb.InhouseBalance
                };

                racklistPoco.Add(rackPoco);
            }
            return racklistPoco;
        }
    }
}
