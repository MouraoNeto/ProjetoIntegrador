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

        public void UpdateList(List<int> idsToUpdate, List List)
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
            
            for(int i=0; i<= idsToUpdate.Count; i++)
            {
                if(i == idsToUpdate[j])
                {
                    aux.Valor = aux.Valor.Substring(0, 3);
                    aux.Valor = "1" + aux.Valor;
                    if (aux.Type != Enums.ImgType.ArvoreFrutifera) aux.Type++;
                    j++;

                    if (j == idsToUpdate.Count)
                        break;
                }
                else
                {
                    aux.Valor = aux.Valor.Substring(0, 3);
                    aux.Valor = "0" + aux.Valor;
                    if(aux.Type != Enums.ImgType.ArvoreSeca) aux.Type--;
                }
                aux = aux.Proximo;
            }
        }
    }
}