﻿using Proy1_Diseno_InvestSys.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.Model
{
    public class TermDeposit : InvSystem
    {
        private float retention = 0.08f;
        public TermDeposit(string name, float investedAmount, int totalTerms, Currency currency, RatesTable ratesTable) : base(name, investedAmount, totalTerms, currency, ratesTable) { }
        public override void calculateProduction()
        {
            _minimumTerms = 30;
            _totalProductions = 0;

            if (totalTerms >= ratesTable.matrix[0][0] && totalTerms <= ratesTable.matrix[1][1])
                _minimumAmount = 100000;
            else
                _minimumAmount = 50000;

            if (totalTerms < _minimumTerms && investedAmount < _minimumAmount)
            {
                Console.WriteLine("No cumple requisitos");
                throw new Exception("No cumple requisitos");
            }

            else if (totalTerms >= ratesTable.matrix[(ratesTable.rows - 1)][0])
            {
                _annualRate = (float)ratesTable.matrix[(ratesTable.rows - 1)][2];
            } else {
                for (int i = 0; i < ratesTable.rows; i++)
                {
                    if (totalTerms >= ratesTable.matrix[i][0] && totalTerms <= ratesTable.matrix[i][1])
                    {
                        _annualRate = (float)ratesTable.matrix[i][2];
                    }
                }
            }

            for (int i = 1; i < totalTerms; i++)
            {
                totalProductions += investedAmount * (i / 360);
            }
            _finalAmount = totalProductions + investedAmount - (totalProductions * retention);
        }
    }
}
