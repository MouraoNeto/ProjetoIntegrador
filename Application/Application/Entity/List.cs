using Application.Enums;
using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Entity
{
    public class List
    {
        public Page _start, _end;

        public void insertElement(string value, ImgType type)
        {
            Page newPage = new Page()
            {
                Valor = value,
                Type = type, LastAccess = DateTime.Now
            };

            if(_start == null)
            {
                _start = newPage;
            }
            else
            {
                _end.Proximo = newPage;
            }

            _end = newPage;
        }

        public List CreateEmptyList()
        {
            List newList = new List();

            newList.insertElement("0000", ImgType.ArvoreSeca);
            newList.insertElement("0000", ImgType.ArvoreSeca);
            newList.insertElement("0000", ImgType.ArvoreSeca);
            newList.insertElement("0000", ImgType.ArvoreSeca);

            return newList;
        }
    }
}