using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Entity
{
    public interface PageSubstituitionAlgorithm
    {
        void SubstituitePage(List List);

        void UpdateList(List<int> idsToUpdate, List List, bool insertNewPage);
    }
}