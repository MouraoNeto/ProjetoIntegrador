using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador.Entidades
{
    [Table("BitReference")]
    public class BitReference : BaseEntity
    {
        public int Num1 { get; set; }
    }
}