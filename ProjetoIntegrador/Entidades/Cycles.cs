using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador.Entidades
{
    [Table("Cycles")]
    public class Cycles : BaseEntity
    {
        public int Numero { get; set; }
    }
}