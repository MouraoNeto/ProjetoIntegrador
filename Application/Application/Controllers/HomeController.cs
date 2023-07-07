using Application.Entity;
using Application.Models;
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
            ReturnModel aux = new ReturnModel(ListModel.List);

            return View("~/Views/Aging.cshtml", aux);
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
            ReturnModel aux = new ReturnModel(ListModel.List);

            return View("~/Views/WsClock.cshtml", aux);
        }

        public ActionResult UpdateWsClockList(List<int> idsToUpdate, bool insertNewPage)
        {
            WsClock wsClock = new WsClock();
            if(idsToUpdate != null)
            {
                idsToUpdate.Sort();
            }

            wsClock.UpdateList(idsToUpdate, ListModel.List, insertNewPage);

            ReturnModel aux = new ReturnModel(ListModel.List);

            return View("~/Views/WsClock.cshtml", aux);
        }

        public ActionResult UpdateAgingList(List<int> idsToUpdate, bool insertNewPage)
        {
            Aging aging = new Aging();

            aging.UpdateList(idsToUpdate, ListModel.List, insertNewPage);

            ReturnModel aux = new ReturnModel(ListModel.List);

            aux.LRU = idsToUpdate[0];

            List<DateTime> dateTimes = new List<DateTime>();
            Page pageAux = ListModel.List._start;

            while (pageAux != null)
            {
                dateTimes.Add(pageAux.LastAccess);

                pageAux = pageAux.Proximo;
            }

            DateTime minDate = dateTimes.Min();

            pageAux = ListModel.List._start;

            int i = 0;

            while (pageAux != null)
            {
                if (pageAux.LastAccess == minDate)
                    break;
                i++;
                pageAux = pageAux.Proximo;
            };

            aux.PageSusceptible = i;

            return View("~/Views/Aging.cshtml", aux);
        }
    }
}