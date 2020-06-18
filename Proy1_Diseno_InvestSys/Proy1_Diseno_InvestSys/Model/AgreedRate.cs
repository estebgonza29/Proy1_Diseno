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
            Console.WriteLine("calculateProduction AgreedRate");
            throw new NotImplementedException();
        }
    }
}
