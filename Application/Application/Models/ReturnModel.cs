﻿using Application.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Models
{
    public class ReturnModel
    {
        public List List = new List();

        public ReturnModel(List list)
        {
            List = list;
        }
    }
}