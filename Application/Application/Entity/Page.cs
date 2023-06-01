using Application.Enums;
using System;

namespace Application.Entity
{
    public class Page
    {
        private string _valor;
        private Page _proximo;
        private Page _anterior;

        public string Valor { 
            get { return _valor; }
            set { _valor = value; }
        }

        public Page Proximo
        {
            get { return _proximo; }
            set { _proximo = value; }
        }

        public Page Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }

        public ImgType Type { get; set; }

        public DateTime LastAccess { get; set; }
    }
}