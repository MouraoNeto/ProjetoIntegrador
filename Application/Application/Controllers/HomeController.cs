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
            return PartialView("~/Views/About.cshtml");
        }

        public ActionResult Aging()
        {
            return PartialView("~/Views/Aging.cshtml");
        }

        public ActionResult HowUse()
        {
            return PartialView("~/Views/HowUse.cshtml");
        }

        public ActionResult Simulation()
        {
            return PartialView("~/Views/Simulation.cshtml");
        }

        public ActionResult WsClock()
        {
            return PartialView("~/Views/WsClock.cshtml");
        }
    }
}