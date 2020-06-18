using Proy1_Diseno_InvestSys.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proy1_Diseno_InvestSys.Model
{
    public abstract class InvSystem
    {
        protected string _name;
        protected int _totalTerms;
        protected int _minimumTerms = 0;
        protected float _investedAmount;
        protected float _minimumAmount = 0;
        protected float _totalProductions = 0;
        protected float _annualRate = 1;
        protected object _ratesTable;
        //protected Currency _currency;

        public InvSystem()
        {
            _name = "";
            _investedAmount = 0;
            _totalTerms = 0;
            _ratesTable = new RatesTable();
        }

        public InvSystem(string name, float investedAmount, int totalTerms/*, RatesTable ratesTable/*, Currency currency*/)
        {
            this._name = name;
            this._investedAmount = investedAmount;
            this._totalTerms = totalTerms;
            //this._currency = _currency;
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int totalTerms
        {
            get { return _totalTerms; }
            set { _totalTerms = value; }
        }

        public int minimumTerms
        {
            get { return _minimumTerms; }
            set { _minimumTerms = value; }
        }

        public float investedAmount
        {
            get { return _investedAmount; }
            set { _investedAmount = value; }
        }

        public float minimumAmount
        {
            get { return _minimumAmount; }
            set { _minimumAmount = value; }
        }

        public float totalProductions
        {
            get { return _totalProductions; }
            set { _totalProductions = value; }
        }

        public float annualRate
        {
            get { return _annualRate; }
            set { _annualRate = value; }
        }

        public object ratesTable 
        {
            get { return _ratesTable; }
            set { _ratesTable = value; } 
        }

        /*public Currency currency
        {
            get { return _currency; }
            set { _currency = value; }
        }*/

        /*public RatesTable ratesTable
        {
            get { return _ratesTable; }
            set { _ratesTable = value; }
        }*/

        public bool checkValidCurrency()
        {
            return true;
        }

        public abstract void calculateProduction();
    }
}
