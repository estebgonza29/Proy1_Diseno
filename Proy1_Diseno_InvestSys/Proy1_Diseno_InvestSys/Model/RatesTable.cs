using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Proy1_Diseno_InvestSys.Model
{
    public class RatesTable
    {
        private List<List<float>> _matrix;
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
        public List<List<float>> matrix { get => _matrix; set => _matrix = value; }

        public RatesTable()
        {
            this._rows = 0;
            this._columns = 0;
            _matrix = new List<List<float>>();
        }

        public void addRow()
        {


            _rows += 1;
        }
    }
}
