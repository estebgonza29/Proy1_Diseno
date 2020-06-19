using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

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
            JToken token = JObject.Parse(File.ReadAllText(@"JSonFiles/CurrentRate.json"));
            Object[][] listaDatos = (token.SelectToken("Data")).ToObject<Object[][]>();
            for (int i = 0; i < _ratesTable.rows; i++)
            {
                for (int j = 0; j < _ratesTable.columns; j++)
                {
                    _ratesTable.matrix[i][j] = (float)listaDatos[i][j];
                }
            }
        }

        public RatesTable getResult()
        {
            return _ratesTable;
        }

    }
}
