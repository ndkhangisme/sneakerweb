using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TramCam.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Suggestions for you";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Suggestions for you";

            return View();
        }
        public ActionResult Kids()
        {
            ViewBag.Message = "Suggestions for you";

            return View();
        }

        public ActionResult Aboutus()
        {
            return View();
        }

    }
}