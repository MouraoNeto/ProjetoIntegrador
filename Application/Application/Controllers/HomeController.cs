using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Application.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return PartialView("~/Views/Index.cshtml");
        }

        public ActionResult About()
        {
            return View("~/Views/About.cshtml");
        }

        public ActionResult Home()
        {
            return View("~/Views/Home.cshtml");
        }

        public ActionResult Aging()
        {
            return View("~/Views/Aging.cshtml");
        }

        public ActionResult HowUse()
        {
            return View("~/Views/HowUse.cshtml");
        }

        public ActionResult Simulation()
        {
            return View("~/Views/Simulation.cshtml");
        }

        public ActionResult WsClock()
        {
            return View("~/Views/WsClock.cshtml");
        }
    }
}