using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.Model
{
    abstract class RateTableBuilder
    {
        protected RatesTable _ratesTable;

        public RateTableBuilder()
        {
            _ratesTable = new RatesTable();
        }
        public RatesTable ratesTable
        {
            get { return _ratesTable; }
            set { _ratesTable = value; }
        }
        public void buildTable()
        {
            
        }
    }
}
