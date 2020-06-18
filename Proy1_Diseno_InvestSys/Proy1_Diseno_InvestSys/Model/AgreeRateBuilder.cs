using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.Model
{
    class AgreeRateBuilder : RateTableBuilder
    {
        public AgreeRateBuilder() : base()
        {            
            _ratesTable.rows = 11;
            _ratesTable.columns = 4;
        }

        public void buildTable()
        {
            
        }

        public RatesTable getResult()
        {
            return _ratesTable;
        }
    }
}
