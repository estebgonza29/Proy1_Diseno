using Proy1_Diseno_InvestSys.Controller;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.Model
{
    public class Current : InvSystem
    {
        public Current(string name, float investedAmount, int totalTerms, Currency currency, RatesTable ratesTable) : base(name, investedAmount, totalTerms, currency, ratesTable) { }
        public override void calculateProduction(DTOData dto)
        {
            _minimumAmount = 25000;
            _totalProductions = 0;
        }
        public override void calculateProduction()
        {
            Console.WriteLine(1);
            if (investedAmount < _minimumAmount)
            {
                Console.WriteLine(2);
                Console.WriteLine("No cumple monto mínimo");
                throw new Exception("No cumple monto mínimo");
            }
            else if (investedAmount >= ratesTable.matrix[(ratesTable.rows - 1)][0])
            {
                Console.WriteLine(3);
                _annualRate = ratesTable.matrix[(ratesTable.rows - 1)][2];
            } else {
                Console.WriteLine(4);
                for (int i = 0; i < (ratesTable.rows - 1); i++)
                {
                    if (investedAmount >= ratesTable.matrix[i][0] && investedAmount <= ratesTable.matrix[i][1])
                    {
                        _annualRate = ratesTable.matrix[i][2];
                    }
                }
            }

            for (int i = 1; i < totalTerms; i++)
            {
                totalProductions += investedAmount * (_annualRate / 360);
            }
            dto.AnnualRate = _annualRate;
            dto.TotalProductions = _totalProductions;
        }
    }
}
