using ProjetoIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoIntegrador.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return PartialView("~/Views/Project.cshtml");
        }

        public ActionResult Teste(ProjectModel model)
        {
            JsonResult result = new JsonResult();

            return result;
        }
    }
}