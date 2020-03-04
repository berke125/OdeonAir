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
    public class ReservationController : ApiController
    {
        private dbLINQDataContext db = new dbLINQDataContext();

        public ReservationPoco GetById(int id)
        {
            ReservationPoco reservationpoco = null;

            var reservationdb = db.ReservationVIEW.FirstOrDefault(x => x.Id == id);
          
            if (reservationdb != null)
            {
                reservationpoco = new ReservationPoco
                {
                    Room_No = reservationdb.RoomNo,
                    FirstName = reservationdb.Firstname,
                    LastName = reservationdb.Lastname,
                    FromDate = reservationdb.Fromdate,
                    ToDate = reservationdb.Todate,
                    RoomType = reservationdb.RoomType,
                    Nation = reservationdb.Nation,
                    VIPStatus = reservationdb.VIPStatusText,
                    Phone = reservationdb.Phone,
                    ContractName = reservationdb.ContractName,
                    Status = reservationdb.StatusText,
                    NumberOfChild = reservationdb.NumberOfChild,
                    ChildAge1 = reservationdb.ChildAge1,
                    ChildAge2 = reservationdb.ChildAge2,
                    ChildAge3 = reservationdb.ChildAge3,
                    ChildAge4 = reservationdb.ChildAge4,
                    NumberOfBaby = reservationdb.NumberOfBaby,
                    BabyAge1 = reservationdb.BabyAge1,
                    BabyAge2 = reservationdb.BabyAge2,
                    BookDate = reservationdb.BookDate
                };
            }
            else
            {
                reservationpoco = new ReservationPoco();
            }

            return reservationpoco;
                


        }
        public List<ReservationPoco> GetReservationbyRoomNo(int Otel_Id, string room_number)
        {
            List<ReservationVIEW> reservationList = (from x in db.ReservationVIEW
                                                     where x.HotelId == Otel_Id && x.RoomNo == room_number
                                                     select x).ToList();
            List<ReservationPoco> reservationPocoList = new List<ReservationPoco>();

            foreach (var reservationdb in reservationList)
            {
                ReservationPoco reservationpoco = new ReservationPoco
                {
                    Room_No = reservationdb.RoomNo,
                    FirstName = reservationdb.Firstname,
                    LastName = reservationdb.Lastname,
                    FromDate = reservationdb.Fromdate,
                    ToDate = reservationdb.Todate,
                    RoomType = reservationdb.RoomType,
                    Nation = reservationdb.Nation,
                    VIPStatus = reservationdb.VIPStatusText,
                    Phone = reservationdb.Phone,
                    ContractName = reservationdb.ContractName,
                    Status = reservationdb.StatusText,
                    NumberOfChild = reservationdb.NumberOfChild,
                    ChildAge1 = reservationdb.ChildAge1,
                    ChildAge2 = reservationdb.ChildAge2,
                    ChildAge3 = reservationdb.ChildAge3,
                    ChildAge4 = reservationdb.ChildAge4,
                    NumberOfBaby = reservationdb.NumberOfBaby,
                    BabyAge1 = reservationdb.BabyAge1,
                    BabyAge2 = reservationdb.BabyAge2,
                    BookDate = reservationdb.BookDate
                };
                reservationPocoList.Add(reservationpoco);

            }
            return reservationPocoList;
        }
    }
}
