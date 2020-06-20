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
        protected float _finalAmount = 0;
        protected Currency _currency;
        protected RatesTable _ratesTable;

        private InvSystem()
        {
            _name = "";
            _investedAmount = 0;
            _totalTerms = 0;
            _ratesTable = new RatesTable();
            _currency = new Currency();
    }

        public InvSystem(string name, float investedAmount, int totalTerms, Currency currency, RatesTable ratesTable) {
            this._name = name;
            this._investedAmount = investedAmount;
            this._totalTerms = totalTerms;
            this._currency = currency;
            this._ratesTable = ratesTable;
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

        public float finalAmount
        {
            get { return _finalAmount; }
            set { _finalAmount = value; }
        }

        public Currency currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        public RatesTable ratesTable
        {
            get { return _ratesTable; }
            set { _ratesTable = value; }
        }

        public bool checkValidCurrency()
        {
            if (_currency.Equals(Currency.CRC))
                return true;
            else if (_currency.Equals(Currency.USD))
                return true;
            else
                return false;
        }

        public abstract void calculateProduction();
    }
}