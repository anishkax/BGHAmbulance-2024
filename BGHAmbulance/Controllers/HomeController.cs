using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BGHAmbulance.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Revolutionizing modern living with innovative, convenient smart solutions";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Get In Touch With Us";

            return View();
        }
    }
}