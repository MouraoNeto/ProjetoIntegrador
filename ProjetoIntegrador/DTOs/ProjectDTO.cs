using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador.DTOs
{
    public class ProjectDTO
    {
        #region [Aging] PROPRIETS
        public int Contador { get; set; }
        #endregion

        #region [Cycles] PROPRIETS
        public int NumeroDeCiclos { get; set; }
        #endregion

        #region [MemorySize] PROPRIETS
        public int Tamanho { get; set; }
        #endregion

        #region [Pages] PROPRIETS
        public int CodigoDaPagina { get; set; }
        public int NumeroDaPagina { get; set; }
        #endregion

        #region [BitReference] PROPRIETS
        public int BitNumber { get; set; }
        #endregion

        #region [WsClock] PROPRIETS
        public string TLU { get; set; }
        public int BitM { get; set; }
        public int CVT { get; set; }
        public int Age { get; set; }
        #endregion
    }
}