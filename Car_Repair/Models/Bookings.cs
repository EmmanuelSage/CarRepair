using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Car_Repair.Models
{
    public class Bookings
    {
        public int bookingsId { get; set; }
        [DisplayName("Name")]
        public string CustomerName { get; set; }

        [DisplayName("Booking Date (dd/mm/yyyy)")]
        public string bookDate { get; set; }
        [DisplayName("Car Make")]
        public string carMake { get; set; }

        [DisplayName("What is the Problem With your car")]
        public string carIssue { get; set; }


    }
}