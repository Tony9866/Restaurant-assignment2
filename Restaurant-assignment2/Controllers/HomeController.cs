using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_assignment2.Controllers
{
    public class HomeController : Controller
    {
        //GET: /home index
        public ActionResult Index()
        {
            return View();
        }

        //GET contact
        public ActionResult Contact()
        {
            ViewBag.Message = "The Phone Number: 700 1234 25@";

            return View();
        }
    }
}