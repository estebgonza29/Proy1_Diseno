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
        private float annualRate;
        private float totalProductions;

        public DTOData() {
            name = "";
            investmentSystem = 0;
            investedAmount = 0;
            totalTerms = 0;
            currency = 0;
            retention = 0;
            ratesTable = null;
            annualRate = 0;
            totalProductions = 0;
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

        public float AnnualRate
        {
            get { return annualRate; }
            set { annualRate = value; }
        }

        public float TotalProductions
        {
            get { return totalProductions; }
            set { totalProductions = value; }
        }

        public RatesTable RatesTable {
            get { return ratesTable; }
            set { ratesTable = value; }
        }

        public override string ToString() {
            string val = "";
            val += "Cliente:" + name + "\n";
            val += "Monto de ahorro de inversión:" + currency.ToString() + " " + InvestedAmount + "\n";
            val += "Plazo:" + totalTerms + "\n";
            val += "Sistema de ahorro de inversión:" + investmentSystem.ToString().Replace('_', ' ') + "\n";
            val += "Interés anual correspondiente:" + (annualRate * 100) +  "%" + "\n";
            val += "Intereses ganados:" + totalProductions + "\n";
            if (retention != 0)
            {
                val += "Impuesto de renta:" + (totalProductions * retention) + "\n";
                val += "Saldo final:" + Math.Round(((double)(totalProductions + investedAmount - (totalProductions * retention))), 2);
            }
            else 
            {
                val += "Saldo final:" + Math.Round(((double)(totalProductions + investedAmount)), 2);
            }
            
            return val;
        }
    }
}
