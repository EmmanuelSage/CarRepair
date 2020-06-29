using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Car_Repair.Models;

namespace Car_Repair.Controllers
{
    public class LocationsController : Controller
    {
        // GET: Locations
        public ActionResult Index()
        {
            var customer = MvcApplication.Customerdb;
            return View(customer);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            //if (ModelState.IsValid)
            //{
                MvcApplication.Customerdb.Add(customer);
                return RedirectToAction("Index", "Home");
           // }
            //else
           // {
             //   customer.LoginErrorMessage = "Wrong Information";
              //  return RedirectToAction("Create", customer);
           // }
        }


    }
}