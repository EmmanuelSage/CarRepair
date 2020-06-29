using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Car_Repair.Models;

namespace Car_Repair.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Locations()
        {
            return View();
        }

        public ActionResult Maintenance()
        {
            return View();
        }

        public ActionResult Price_List()
        {
            return View();
        }

        public ActionResult Repair()
        {
            return View();
        }

        public ActionResult Book()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Book(Bookings booked)
        {
            MvcApplication.Bookingsdb.Add(booked);
            return View("index");
        }
    }
}