using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador.Entidades
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}