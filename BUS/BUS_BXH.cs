﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_BXH
    {
        DAL_BANGXEPHANG bxh = new DAL_BANGXEPHANG();
    
        public IQueryable LayDS()
        {
            return bxh.LayDS();
        }
    }
}
