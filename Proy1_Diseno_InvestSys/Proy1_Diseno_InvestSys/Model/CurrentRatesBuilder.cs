using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.Model
{
    class CurrentRatesBuilder : RateTableBuilder
    {
        
        public void buildTable()
        {
            _ratesTable = new RatesTable();
            _ratesTable.addRow();
        }

        public RatesTable getResult()
        {
            return _ratesTable;
        }

    }
}
