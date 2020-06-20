using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Proy1_Diseno_InvestSys.Model
{
    class AgreeRateBuilder : RateTableBuilder
    {
        public AgreeRateBuilder() : base()
        {            
            _ratesTable.rows = 7;
            _ratesTable.columns = 4;
        }

        public void buildTable()
        {
            List<float> L1 = new List<float>();
            L1.Add(15);
            L1.Add(29);
            L1.Add(0.0485f);
            L1.Add(0.008f);
            List<float> L2 = new List<float>();
            L2.Add(30);
            L2.Add(59);
            L2.Add(0.0494f);
            L2.Add(0.0091f);
            List<float> L3 = new List<float>();
            L3.Add(60);
            L3.Add(89);
            L3.Add(0.0523f);
            L3.Add(0.0106f);
            List<float> L4 = new List<float>();
            L4.Add(90);
            L4.Add(179);
            L4.Add(0.0581f);
            L4.Add(0.0144f);
            List<float> L5 = new List<float>();
            L5.Add(180);
            L5.Add(269);
            L5.Add(0.0883f);
            L5.Add(0.0221f);
            List<float> L6 = new List<float>();
            L6.Add(270);
            L6.Add(359);
            L6.Add(0.0869f);
            L6.Add(0.0226f);
            List<float> L7 = new List<float>();
            L7.Add(360);
            L7.Add(float.PositiveInfinity);
            L7.Add(0.0869f);
            L7.Add(0.0240f);
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
