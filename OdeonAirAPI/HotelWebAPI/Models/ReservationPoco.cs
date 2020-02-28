using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelWebAPI.Models
{
    public class ReservationPoco
    {
        public string Room_No { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string RoomType { get; set; }
        public string Nation { get; set; }
        public string VIPStatus { get; set; }
        public string Phone { get; set; }
        public string ContractName { get; set; }
        public string Status { get; set; }
        public int NumberOfChild { get; set; }
        public int ChildAge1 { get; set; }
        public int ChildAge2 { get; set; }
        public int ChildAge3 { get; set; }
        public int ChildAge4 { get; set; }
        public int NumberOfBaby { get; set; }
        public int BabyAge1 { get; set; }
        public int BabyAge2 { get; set; }
        public DateTime? BookDate { get; set; }
    }
}