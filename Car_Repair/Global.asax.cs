using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Car_Repair.Models;

namespace Car_Repair
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static List<Customer> Customerdb = new List<Customer>();
        public static List<Bookings> Bookingsdb = new List<Bookings>();
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
