using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Entity
{
    public class Aging : PageSubstituitionAlgorithm
    {
        public void SubstituitePage(List List)
        {
            Page aux = new Page();

            List<DateTime> dateTimes = new List<DateTime>();

            aux = List._start;

            while (aux != null)
            {
                dateTimes.Add(aux.LastAccess);

                aux = aux.Proximo;
            }

            DateTime minDate = dateTimes.Min();

            aux = List._start;

            int i = 0;

            while (aux != null)
            {
                if (i == 0 && aux.LastAccess == minDate)
                {
                    Page newPage = new Page()
                    {
                        Proximo = aux.Proximo,
                        Valor = "0000",
                        LastAccess = DateTime.Now,
                        Type = Enums.ImgType.ArvoreSeca
                    };

                    List._start = newPage;
                    break;
                }
                if (aux.Proximo.LastAccess == minDate)
                {
                    Page newPage = new Page()
                    {
                        Proximo = aux.Proximo.Proximo,
                        Valor = "0000",
                        LastAccess = DateTime.Now,
                        Type = Enums.ImgType.ArvoreSeca
                    };

                    if (aux.Proximo.Proximo == null)
                        List._end = newPage;

                    aux.Proximo = newPage;

                    break;
                }

                aux = aux.Proximo;
                i++;
            }
        }

        public void UpdateList(List<int> idsToUpdate, List List, bool insertNewPage)
        {
            Page aux = new Page();

            foreach(int index in idsToUpdate)
            {
                aux = List._start;

                for(int i=0; i < 4; i++)
                {
                    if (i == index)
                    {
                        aux.LastAccess = DateTime.Now;
                    }

                    aux = aux.Proximo;
                }
            }

            if (insertNewPage)
                SubstituitePage(List);
        }
    }
}