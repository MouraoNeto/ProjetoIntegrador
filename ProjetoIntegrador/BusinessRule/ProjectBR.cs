using ProjetoIntegrador.DTOs;
using ProjetoIntegrador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador.BusinessRule
{
    public static class ProjectBR
    {
        public static void CreateForm(ProjectDTO dTO)
        {
            try
            {
                Aging aging = new Aging()
                {
                    Contador = dTO.Contador
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}