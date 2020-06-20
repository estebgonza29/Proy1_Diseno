using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Proy1_Diseno_InvestSys.Model
{
    class TermDepositRatesBuilder : RateTableBuilder
    {
        public TermDepositRatesBuilder() : base()
        {
            _ratesTable.rows = 7;
            _ratesTable.columns = 3;
        }
        public override void buildTable()
        {
            JToken token = JObject.Parse(File.ReadAllText(@"JSonFiles/TermDepositRate.json"));
            Object[][] listaDatos = (token.SelectToken("Data")).ToObject<Object[][]>();
            for (int i = 0; i < _ratesTable.rows; i++)
            {
                for (int j = 0; j < _ratesTable.columns; j++)
                {
                    _ratesTable.matrix[i][j] = (float)listaDatos[i][j];
                    Console.WriteLine(_ratesTable.matrix[i][j]);
                }
            }
        }

        public RatesTable getResult()
        {
            return _ratesTable;
        }
    }
}
