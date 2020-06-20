using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Proy1_Diseno_InvestSys.Model
{
    class CurrentRatesBuilder : RateTableBuilder
    {
        public CurrentRatesBuilder() : base()
        {
            _ratesTable.rows = 5;
            _ratesTable.columns = 3;
        }
        public override void buildTable()
        {
            List<float> L1 = new List<float>();
            L1.Add(25000);
            L1.Add(500000);
            L1.Add(0.01f);
            List<float> L2 = new List<float>();
            L2.Add(500001);
            L2.Add(1000000);
            L2.Add(0.02f);
            List<float> L3 = new List<float>();
            L3.Add(1000001);
            L3.Add(2500000);
            L3.Add(0.0225f);
            List<float> L4 = new List<float>();
            L4.Add(2500001);
            L4.Add(10000000);
            L4.Add(0.025f);
            List<float> L5 = new List<float>();
            L5.Add(10000001);
            L5.Add(float.PositiveInfinity);
            L5.Add(0.0275f);
            _ratesTable.matrix.Add(L1);
            _ratesTable.matrix.Add(L2);
            _ratesTable.matrix.Add(L3);
            _ratesTable.matrix.Add(L4);
            _ratesTable.matrix.Add(L5);
        }

        public RatesTable getResult()
        {
            return _ratesTable;
        }

    }
}
