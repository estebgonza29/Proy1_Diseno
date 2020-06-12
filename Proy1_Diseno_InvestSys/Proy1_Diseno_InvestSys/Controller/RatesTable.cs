using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.Controller
{
    class RatesTable
    {
        private int rows;
        private int columns;

        RatesTable(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }

        public void addRow()
        {
            rows += 1;
        }
    }
}
