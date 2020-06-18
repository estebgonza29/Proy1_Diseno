using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.Model
{
    class CurrentRatesBuilder : RateTableBuilder
    {
        public CurrentRatesBuilder() : base()
        {
            _ratesTable.rows = 5;
            _ratesTable.columns = 3;
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
