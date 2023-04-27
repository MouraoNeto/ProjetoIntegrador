using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador.Entidades
{
    [Table("MemorySize")]
    public class MemorySize : BaseEntity
    {
        public int Tamanho { get; set; }
    }
}