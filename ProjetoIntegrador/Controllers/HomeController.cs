using ProjetoIntegrador.DBC;
using ProjetoIntegrador.DTOs;
using ProjetoIntegrador.Entidades;
using ProjetoIntegrador.Models;
using System;
using System.Web.Mvc;

namespace ProjetoIntegrador.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return PartialView("~/Views/Project.cshtml");
        }

        public ActionResult ControllerMethod(int option)
        {
            try
            {
                switch (option)
                {
                    case 1:
                        return PartialView("~/Views/Forms/AgingForm.cshtml");
                    case 2:
                        return PartialView("~/Views/Forms/BitReferenceForm.cshtml");
                    case 3:
                        return PartialView("~/Views/Forms/CyclesForm.cshtml");
                    case 4:
                        return PartialView("~/Views/Forms/MemorySizeForm.cshtml");
                    case 5:
                        return PartialView("~/Views/Forms/PagesForm.cshtml");
                    case 6:
                        return PartialView("~/Views/Forms/WsClockForm.cshtml");
                    case 7:
                        AgingBDC.GetAgingList();
                        break;
                    case 8:
                        BitReferenceDBC.GetBitReferenceList();
                        break;
                    case 9:
                        CyclesDBC.GetCyclesList();
                        break;
                    case 10:
                        MemorySizeDBC.GetMemorySizeList();
                        break;
                    case 11:
                        PagesDBC.GetPagesList();
                        break;
                    case 12:
                        WsClockDBC.GetWsClockList();
                        break;
                }
                return Json(new { Status = "OK", Message = "aaaaa" });
            }
            catch (Exception ex)
            {
                return Json(new { Status = "NOK", Message = ex.Message });
            }
        }


        public ActionResult CreateAging(AgingModel model)
        {
            try
            {

                Aging aging = new Aging()
                {
                    Contador = model.Contador
                };

                AgingBDC.InsertAging(aging);

                return Json(new { Status = "OK", Message = "Aging criado com sucesso!"});
            }
            catch (Exception ex)
            {
                return Json(new { Status = "NOK", Message = ex.Message });
            }
        }
        public ActionResult CreateBitReference(BitReferenceModel model)
        {
            try
            {

                BitReference bitReference = new BitReference()
                {
                    Num1 = model.BitNumber
                };

                BitReferenceDBC.InsertBitReference(bitReference);

                return Json(new { Status = "OK", Message = "BitReference criado com sucesso!" });
            }
            catch (Exception ex)
            {
                return Json(new { Status = "NOK", Message = ex.Message });
            }
        }
        public ActionResult CreateCycles(CyclesModel model)
        {
            try
            {

                Cycles Cycles = new Cycles()
                {
                    Numero = model.NumeroDeCiclos
                };

                CyclesDBC.InsertCycles(Cycles);

                return Json(new { Status = "OK", Message = "Cycles criado com sucesso!" });
            }
            catch (Exception ex)
            {
                return Json(new { Status = "NOK", Message = ex.Message });
            }
        }
        public ActionResult CreateMemorySize(MemorySizeModel model)
        {
            try
            {

                MemorySize MemorySize = new MemorySize()
                {
                    Tamanho = model.Tamanho
                };

                MemorySizeDBC.InsertMemorySize(MemorySize);

                return Json(new { Status = "OK", Message = "MemorySize criado com sucesso!" });
            }
            catch (Exception ex)
            {
                return Json(new { Status = "NOK", Message = ex.Message });
            }
        }
        public ActionResult CreatePages(PagesModel model)
        {
            try
            {

                Pages Pages = new Pages()
                {
                    Numero = model.NumeroDaPagina,
                    Cod = model.CodigoDaPagina
                };

                PagesDBC.InsertPages(Pages);

                return Json(new { Status = "OK", Message = "Pages criado com sucesso!" });
            }
            catch (Exception ex)
            {
                return Json(new { Status = "NOK", Message = ex.Message });
            }
        }
        public ActionResult CreateWsClock(WsClockModel model)
        {
            try
            {

                WsClock WsClock = new WsClock()
                {
                    Age = model.Age,
                    BitM = model.BitM,
                    CVT = model.CVT,
                    TLU = model.TLU
                };

                WsClockDBC.InsertWsClock(WsClock);

                return Json(new { Status = "OK", Message = "WsClock criado com sucesso!" });
            }
            catch (Exception ex)
            {
                return Json(new { Status = "NOK", Message = ex.Message });
            }
        }
    }
}