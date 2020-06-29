using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Car_Repair.Models;

namespace Car_Repair.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autherize( LoginDetails UserDetails)
        {
            if (UserDetails.UserName == "Admin" && UserDetails.Password == "passion")
            {
                Session["UserName"] = UserDetails.UserName;                
                return RedirectToAction("index");
            }
            else
            {
                UserDetails.LoginErrorMessage = "Wrong UserName or Password";
                return View("Login", UserDetails);
            }
            
        }

        public ActionResult Bookings()
        {
            var booked = MvcApplication.Bookingsdb;
            return View(booked);
            
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }
    }
}