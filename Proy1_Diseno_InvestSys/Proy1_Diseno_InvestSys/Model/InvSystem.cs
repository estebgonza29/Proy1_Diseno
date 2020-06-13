using Proy1_Diseno_InvestSys.Controller;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proy1_Diseno_InvestSys.Model
{
    public abstract class InvSystem {
        protected string name;
        protected int totalTerms;
        protected int minimumTerms = 0;
        protected float investedAmount;
        protected float minimumAmount = 0;
        protected float totalProductions = 0;
        protected float annualRate = 1;
        //protected Currency currency;
        //protected RatesTable ratesTable;

        public InvSystem(string name, float investedAmount, int totalTerms
        //Currency currency,
        //RatesTable ratesTable
        ) {
            this.name = name;
            this.investedAmount = investedAmount;
            this.totalTerms = totalTerms;
            //this.currency = currency;
            //this.ratesTable = ratesTable;
        }

        protected InvSystem()
        {
        }

        public bool checkValidCurrency()
        {
            return true;
        }

        public abstract void calculateProduction();
    }
}
