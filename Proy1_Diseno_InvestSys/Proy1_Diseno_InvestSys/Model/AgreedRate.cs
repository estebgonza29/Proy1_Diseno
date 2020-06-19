using Proy1_Diseno_InvestSys.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.Model
{
    public class AgreedRate : InvSystem
    {
        public AgreedRate(string name, float investedAmount, int totalTerms, Currency currency, RatesTable ratesTable) : base(name, investedAmount, totalTerms, currency, ratesTable) {}
        public override void calculateProduction()
        {
            {
                int posCurrency;
                _minimumTerms = 15;
                _totalProductions = 0;

                if (currency.Equals("CRC"))
                {
                    posCurrency = 2;
                    _minimumAmount = 100000;
                } else {
                    posCurrency = 3;
                    _minimumAmount = 500;
                }

                if (investedAmount < _minimumAmount || totalTerms < _minimumTerms)
                {
                    Console.WriteLine("No cumple requisitos");
                    throw new NotImplementedException();
                } 
                else if (totalTerms >= ratesTable.matrix[(ratesTable.rows - 1)][0])
                {
                    _annualRate = (float)ratesTable.matrix[(ratesTable.rows - 1)][posCurrency];
                } else {
                    for (int i = 0; i < ratesTable.rows; i++)
                    {
                        if (totalTerms >= ratesTable.matrix[i][0] && totalTerms <= ratesTable.matrix[i][1])
                        {
                            _annualRate = (float)ratesTable.matrix[i][posCurrency];
                        }
                    }
                }

                for (int i = 1; i < totalTerms; i++)
                {
                    totalProductions += investedAmount * (i / 360);
                }
                _finalAmount = totalProductions + investedAmount;
            }
        }
    }
}
