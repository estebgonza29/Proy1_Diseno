using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.Model
{
    class RateTableBuilder
    {
        protected RatesTable _ratesTable;
        public RatesTable ratesTable
        {
            get { return _ratesTable; }
            set { _ratesTable = value; }
        }
        public void buildTable()
        {
            _ratesTable = new RatesTable();
            _ratesTable.addRow();
        }
    }
}
