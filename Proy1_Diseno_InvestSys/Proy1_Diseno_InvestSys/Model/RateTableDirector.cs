using Proy1_Diseno_InvestSys.Controller;
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

        public RateTableDirector(RateTableBuilder builder) {
            if (builder == null) throw new Exception("Builder cannot be null.");
            this._rateBuilder = builder;
        }

        public RateTableBuilder rateBuilder
        {
            get { return _rateBuilder; }
            set { _rateBuilder = value; }
        }
        public void construct()
        {
            _rateBuilder.buildTable();
        }
        public RatesTable getTable()
        {
            return _rateBuilder.ratesTable;
        }
    }
}
