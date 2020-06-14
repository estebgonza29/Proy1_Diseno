using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.Model
{
    class RateTableDirector
    {
        private RateTableBuilder _rateBuilder;
        public RateTableBuilder rateBuilder
        {
            get { return _rateBuilder; }
            set { _rateBuilder = value; }
        }
        public void construct(InvestmentType type)
        {

        }
        public RatesTable getTable()
        {
            _rateBuilder.buildTable();
            return _rateBuilder.ratesTable;
        }
    }
}
