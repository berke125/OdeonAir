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
                                          where x.HotelId == Otel_Id
                                          select x).ToList();

            List<RackPoco> racklistPoco = new List<RackPoco>();
            foreach (var rackdb in rackdblist)
            {
                RackPoco rackPoco = new RackPoco
                {
                    ReservationId = rackdb.InId,
                    Room_no = rackdb.RoomNo,
                    Room_color = rackdb.RoomColor,
                    Room_status_name = rackdb.RoomStatusName,
                    Room_type_name = rackdb.RoomTypeName,
                    In_name = rackdb.InName,
                    In_from_date = rackdb.InFromdate,
                    In_to_date = rackdb.InTodate,
                    In_agency = rackdb.InAgency,
                    In_house_balance = rackdb.InhouseBalance
                };

                racklistPoco.Add(rackPoco);
            }
            return racklistPoco;
        }
        public List<RackPoco> GetRacksByFilter(int Otel_Id,string roomsfilter, string name)
        {
            List<_RACKVIEW> rackdblist = new List<_RACKVIEW>();
            switch (roomsfilter)
            {

                case "1":
                    rackdblist = (from x in db._RACKVIEW
                                  orderby x.RoomNo
                                  where x.HotelId == Otel_Id
                                  select x).ToList();
                    break;
                case "2":
                    rackdblist = (from x in db._RACKVIEW
                                  where (x.InName == "" || x.InName == null) && x.HotelId == Otel_Id
                                  orderby x.RoomNo
                                  select x).ToList();
                    break;
                case "3":
                    rackdblist = (from x in db._RACKVIEW
                                  where (x.InName != "" || x.InName != null) && x.HotelId == Otel_Id
                                  orderby x.RoomNo
                                  select x).ToList();
                    break;
                case "4":
                    rackdblist = (from x in db._RACKVIEW

                                  where ((x.InName != "" || x.InName != null) && (x.InhouseBalance < 0)) && x.HotelId == Otel_Id
                                  orderby x.RoomNo
                                  select x).ToList();
                    break;
                case "5":
                    rackdblist = (from x in db._RACKVIEW

                                  where ((x.InName != "" || x.InName != null) && (x.InhouseBalance > 0)) && x.HotelId == Otel_Id
                                  orderby x.RoomNo
                                  select x).ToList();
                    break;
                case "6":
                    rackdblist = (from x in db._RACKVIEW

                                  where ((x.InName != "" || x.InName != null) && (x.InhouseBalance == 0)) && x.HotelId == Otel_Id
                                  orderby x.RoomNo
                                  select x).ToList();
                    break;
            }
            if (string.IsNullOrEmpty(name) == false)
            {
                rackdblist = (from x in rackdblist
                              where (x.InName.Contains(name))
                              select x).ToList();
            }

            List<RackPoco> racklistPoco = new List<RackPoco>();
            foreach (var rackdb in rackdblist)
            {
                RackPoco rackPoco = new RackPoco
                {

                    Room_no = rackdb.RoomNo,
                    Room_color = rackdb.RoomColor,
                    Room_status_name = rackdb.RoomStatusName,
                    Room_type_name = rackdb.RoomTypeName,
                    In_name = rackdb.InName,
                    In_from_date = rackdb.InFromdate,
                    In_to_date = rackdb.InTodate,
                    In_agency = rackdb.InAgency,
                    In_house_balance = rackdb.InhouseBalance
                };

                racklistPoco.Add(rackPoco);
            }


            return racklistPoco;
        }

    }
}
