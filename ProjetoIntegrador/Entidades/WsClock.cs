using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador.Entidades
{
    public class WsClock : BaseEntity
    {
        public DateTime TLU { get; set; }
        public int BitM { get; set; }
        public int CVT { get; set; }
        public int Age { get; set; }
    }
}