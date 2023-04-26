using ProjetoIntegrador.DBC;
using ProjetoIntegrador.DTOs;
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

            try
            {
                ProjectDTO projectDTO = new ProjectDTO()
                {
                    Contador = model.Contador,
                    NumeroDeCiclos = model.NumeroDeCiclos,
                    Tamanho = model.Tamanho,
                    CodigoDaPagina = model.CodigoDaPagina,
                    NumeroDaPagina = model.NumeroDaPagina,
                    BitNumber = model.BitNumber,
                    TLU = model.TLU,
                    BitM = model.BitM,
                    CVT = model.CVT,
                    Age = model.Age
                };

                AgingBDC aging = new AgingBDC();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}