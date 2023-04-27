using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador.Entidades
{
    [Table("Pages")]
    public class Pages : BaseEntity
    {
        public int Cod { get; set; }
        public int Numero { get; set; }
    }
}