using Proy1_Diseno_InvestSys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.Controller
{
    public class DTOData {
        private string name;
        private InvestmentType investmentSystem;
        private float investedAmount;
        private int totalTerms;
        private Currency currency;
        private float retention;
        private RatesTable ratesTable;

        public DTOData() {
            name = "";
            investmentSystem = 0;
            investedAmount = 0;
            totalTerms = 0;
            currency = 0;
            retention = 0;
            ratesTable = null;
        }

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public InvestmentType InvestmentSystem {
            get { return investmentSystem; }
            set { investmentSystem = value; }
        }

        public float InvestedAmount {
            get { return investedAmount; }
            set { investedAmount = value; }
        }

        public int TotalTerms {
            get { return totalTerms; }
            set { totalTerms = value; }
        }

        public Currency Currency {
            get { return currency; }
            set { currency = value; }
        }

        public float Retention {
            get { return retention; }
            set { retention = value; }
        }

        public RatesTable RatesTable {
            get { return ratesTable; }
            set { ratesTable = value; }
        }

        public override string ToString() {
                string val = "";
                val += "name:" + name + ",";
                val += "Investment type:" + investmentSystem.ToString() + ",";
                val += "Invested amount:" + InvestedAmount + ",";
                val += "Total terms:" + totalTerms + ",";
                val += "Currency:" + currency.ToString();
                if (retention != 0) val += ",Retention:" + retention;
                return val;
        }
    }
}
