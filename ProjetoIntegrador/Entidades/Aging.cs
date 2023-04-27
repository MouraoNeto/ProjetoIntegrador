using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador.Entidades
{
    [Table("Aging")]
    public class Aging : BaseEntity
    {
        public int Contador { get; set; }
    }
}