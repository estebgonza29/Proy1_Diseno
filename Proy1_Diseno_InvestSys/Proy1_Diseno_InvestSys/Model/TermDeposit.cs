using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.Model
{
    public class TermDeposit : InvSystem
    {
        private float retention = 0;
        public TermDeposit() : base()
        {

        }
        public override void calculateProduction()
        {
            Console.WriteLine("calculateProduction TermDeposit");
            throw new NotImplementedException();
        }
    }
}
