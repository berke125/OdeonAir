﻿using HotelWebAPI.LINQ;
using HotelWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//namespace HotelWebAPI.Controllers
//{
//    public class RoomViewController : ApiController
//    {
//        private dbLINQDataContext db = new dbLINQDataContext();

//        public List<RoomPoco> GetRoom()
//        {
//            List<ROOMVIEW> roomdblist = (from x in db.ROOMVIEW

//                                         orderby x.ODANO
//                                         select x).ToList();

//            List<RoomPoco> roomlistPoco = new List<RoomPoco>();
//            foreach (var roomdb in roomdblist)
//            {
//                string odano = roomdb.ODANO;
//                RoomPoco roomPoco = new RoomPoco
//                {
//                    OdaNo = roomdb.ODANO,
//                    OdaTip = roomdb.ODATIP,
//                    No = Convert.ToInt32(roomdb.NO),
//                    Title = roomdb.TITLE,
//                    FirstName = roomdb.FIRSTNAME,
//                    LastName = roomdb.LASTNAME,
//                    FromDate = roomdb.FROMDATE,
//                    ToDate = roomdb.TODATE
//                };

//                roomlistPoco.Add(roomPoco);
//            }


//            return roomlistPoco;
//        }
//        public List<RoomPoco> GetRoom()
//        {
//            List<ROOMVIEW> roomdblist = (from x in db.ROOMVIEW

//                                         orderby x.ODANO
//                                         select x).ToList();
//            THEDATE theDate = (from x in db.THEDATE
//                               orderby x.ODEONDATE descending
//                               select x).First();
//            List<RoomPoco> roomlistPoco = new List<RoomPoco>();
//            foreach (var roomdb in roomdblist)
//            {
//                bool IsEndDate = false;
//                bool IsFromDate = false;
//                if (roomdb.TODATE == theDate.ODEONDATE)
//                    IsEndDate = true;
//                if (roomdb.FROMDATE == theDate.ODEONDATE)
//                    IsFromDate = true;
//                RoomPoco roomPoco = new RoomPoco
//                {
//                    OdaNo = roomdb.ODANO,
//                    OdaTip = roomdb.ODATIP,
//                    No = Convert.ToInt32(roomdb.NO),
//                    Title = roomdb.TITLE,
//                    FirstName = roomdb.FIRSTNAME,
//                    LastName = roomdb.LASTNAME,
//                    FromDate = roomdb.FROMDATE,
//                    ToDate = roomdb.TODATE,
//                    IsEndDate = IsEndDate,
//                    IsFromDate = IsFromDate
//                };

//                roomlistPoco.Add(roomPoco);
//            }


//            return roomlistPoco;
//        }
//        public List<RoomPoco> GetRoomsByFilter(string roomsfilter, string name)
//        {
//            List<ROOMVIEW> roomdblist = new List<ROOMVIEW>();
//            switch (roomsfilter)
//            {
//                case "1":
//                    roomdblist = (from x in db.ROOMVIEW
//                                  orderby x.ODANO
//                                  select x).ToList();
//                    break;
//                case "2":
//                    roomdblist = (from x in db.ROOMVIEW
//                                  where (x.LASTNAME == "" || x.LASTNAME == null)
//                                  orderby x.ODANO
//                                  select x).ToList();
//                    break;
//                case "3":
//                    roomdblist = (from x in db.ROOMVIEW
//                                  where (x.LASTNAME != "" || x.LASTNAME != null)
//                                  orderby x.ODANO
//                                  select x).ToList();
//                    break;
//                case "4":
//                    roomdblist = (from x in db.ROOMVIEW
//                                  from y in db.THEDATE
//                                  where ((x.LASTNAME != "" || x.LASTNAME != null) && (x.FROMDATE == y.ODEONDATE))
//                                  orderby x.ODANO
//                                  select x).ToList();
//                    break;
//                case "5":
//                    roomdblist = (from x in db.ROOMVIEW
//                                  from y in db.THEDATE
//                                  where ((x.LASTNAME != "" || x.LASTNAME != null) && (x.TODATE == y.ODEONDATE))
//                                  orderby x.ODANO
//                                  select x).ToList();
//                    break;
//            }
//            if (string.IsNullOrEmpty(name) == false)
//            {
//                roomdblist = (from x in roomdblist
//                              where (x.FIRSTNAME.Contains(name) || x.LASTNAME.Contains(name))
//                              select x).ToList();
//            }

//            THEDATE theDate = (from x in db.THEDATE
//                               orderby x.ODEONDATE descending
//                               select x).First();
//            List<RoomPoco> roomlistPoco = new List<RoomPoco>();
//            foreach (var roomdb in roomdblist)
//            {
//                string odano = roomdb.ODANO;
//                bool IsEndDate = false;
//                bool IsFromDate = false;
//                if (roomdb.TODATE == theDate.ODEONDATE)
//                    IsEndDate = true;
//                if (roomdb.FROMDATE == theDate.ODEONDATE)
//                    IsFromDate = true;
//                RoomPoco roomPoco = new RoomPoco
//                {
//                    OdaNo = roomdb.ODANO,
//                    OdaTip = roomdb.ODATIP,
//                    No = Convert.ToInt32(roomdb.NO),
//                    Title = roomdb.TITLE,
//                    FirstName = roomdb.FIRSTNAME,
//                    LastName = roomdb.LASTNAME,
//                    FromDate = roomdb.FROMDATE,
//                    ToDate = roomdb.TODATE,
//                    IsEndDate = IsEndDate,
//                    IsFromDate = IsFromDate
//                };

//                roomlistPoco.Add(roomPoco);
//            }


//            return roomlistPoco;
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        private bool CustomerExists(string code)
//        {
//            return db.USERS.Count(e => e.CODE == code) > 0;
//        }
//    }
//}
