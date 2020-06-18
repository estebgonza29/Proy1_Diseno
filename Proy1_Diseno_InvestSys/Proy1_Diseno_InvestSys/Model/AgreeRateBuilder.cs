using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Proy1_Diseno_InvestSys.Model
{
    class AgreeRateBuilder : RateTableBuilder
    {
        public AgreeRateBuilder() : base()
        {            
            _ratesTable.rows = 11;
            _ratesTable.columns = 4;
        }

        public void buildTable()
        {            
            JToken token = JObject.Parse(File.ReadAllText(@"JSonFiles/AgreedRate.json"));
            Object[][] listaDatos = (token.SelectToken("Data")).ToObject<Object[][]>(); 
            for(int i = 0; i < _ratesTable.rows; i++)
            {
                for(int j = 0; j < _ratesTable.columns; j++)
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
