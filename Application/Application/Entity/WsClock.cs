using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Entity
{
    public class WsClock : PageSubstituitionAlgorithm
    {
        public void SubstituitePage(Page anterior, Page proximo)
        {
            throw new NotImplementedException();
        }

        public void UpdateList(List<int> idsToUpdate, List List, bool insertNewPage)
        {
            Page aux = new Page();

            aux = List._start;
            int j = 0;

            if(idsToUpdate == null)
            {
                while(aux != null)
                {
                    aux.Valor = aux.Valor.Substring(0, 3);
                    aux.Valor = "0" + aux.Valor;
                    if (aux.Type != Enums.ImgType.ArvoreSeca) 
                        aux.Type--;
                    aux = aux.Proximo;
                }

                return;
            }
            
            for(int i=0; i <= 3; i++)
            {
                if(j != idsToUpdate.Count && i == idsToUpdate[j])
                {
                    aux.Valor = aux.Valor.Substring(0, 3);
                    aux.Valor = "1" + aux.Valor;
                    aux.LastAccess = DateTime.Now;
                    if (aux.Type != Enums.ImgType.ArvoreFrutifera) 
                        aux.Type++;

                    j++;
                }
                else
                {
                    aux.Valor = aux.Valor.Substring(0, 3);
                    aux.Valor = "0" + aux.Valor;
                    if(aux.Type != Enums.ImgType.ArvoreSeca) aux.Type--;
                }
                aux = aux.Proximo;
            }

            if (insertNewPage)
            {
                List<DateTime> dateTimes = new List<DateTime>();

                aux = List._start;

                while (aux != null)
                {
                    dateTimes.Add(aux.LastAccess);
                    
                    aux = aux.Proximo;
                }
                dateTimes.Min();

                DateTime minDate = dateTimes.Min();

                aux = List._start;

                while (aux != null)
                {
                    if(aux.Proximo.LastAccess == minDate)
                    {
                        Page newPage = new Page()
                        {
                            Proximo = aux.Proximo.Proximo,
                            Valor = "0000",
                            LastAccess = DateTime.Now,
                            Type = Enums.ImgType.ArvoreSeca
                        };

                        aux.Proximo = newPage;

                        break;
                    }

                    aux = aux.Proximo;
                }
            }
        }
    }
}