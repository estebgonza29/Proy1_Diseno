using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.Model
{
    class RatesTable
    {
        private int _rows;
        public int rows
        {
            get { return _rows; }
            set { _rows = value; }
        }
        private int _columns;
        public int columns
        {
            get { return _columns; }
            set { _columns = value; }
        }

        public RatesTable()
        {
            this._rows = 0;
            this._columns = 2;
        }

        public void addRow()
        {


            _rows += 1;
        }
    }
}
