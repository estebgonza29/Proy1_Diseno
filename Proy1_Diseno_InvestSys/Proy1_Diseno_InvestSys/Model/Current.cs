﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.Model
{
    public class Current : InvSystem
    {
        public Current() : base()
        {

        }
        public override void calculateProduction()
        {
            Console.WriteLine("calculateProduction Current");
            throw new NotImplementedException();
        }
    }
}