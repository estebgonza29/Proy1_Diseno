using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Proy1_Diseno_InvestSys.Model
{
    class TermDepositRatesBuilder : RateTableBuilder
    {
        public TermDepositRatesBuilder() : base()
        {
            _ratesTable.rows = 7;
            _ratesTable.columns = 3;
        }
        public void buildTable()
        {
            List<float> L1 = new List<float>();
            L1.Add(30);
            L1.Add(59);
            L1.Add(0.054f);
            List<float> L2 = new List<float>();
            L2.Add(60);
            L2.Add(89);
            L2.Add(0.057f);
            List<float> L3 = new List<float>();
            L3.Add(90);
            L3.Add(149);
            L3.Add(0.063f);
            List<float> L4 = new List<float>();
            L4.Add(150);
            L4.Add(179);
            L4.Add(0.0945f);
            List<float> L5 = new List<float>();
            L5.Add(180);
            L5.Add(209);
            L5.Add(0.0995f);
            List<float> L6 = new List<float>();
            L6.Add(210);
            L6.Add(239);
            L6.Add(0.1f);
            List<float> L7 = new List<float>();
            L7.Add(240);
            L7.Add(float.PositiveInfinity);
            L7.Add(0.093f);
            _ratesTable.matrix.Add(L1);
            _ratesTable.matrix.Add(L2);
            _ratesTable.matrix.Add(L3);
            _ratesTable.matrix.Add(L4);
            _ratesTable.matrix.Add(L5);
            _ratesTable.matrix.Add(L6);
            _ratesTable.matrix.Add(L7);
        }

        public RatesTable getResult()
        {
            return _ratesTable;
        }
    }
}
