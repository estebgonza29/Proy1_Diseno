﻿using Proy1_Diseno_InvestSys.Controller;
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
        public Current(string name, float investedAmount, int totalTerms, Currency currency, RatesTable ratesTable) : base(name, investedAmount, totalTerms, currency, ratesTable) {
            _minimumAmount = 25000;
            _totalProductions = 0;
        }
        public override void calculateProduction(DTOData dto)
        {
            if (investedAmount < _minimumAmount)
            {
                throw new Exception("El monto ingresado es menor al monto mínimo");
            }
            else if (investedAmount >= ratesTable.matrix[(ratesTable.rows - 1)][0])
            {
                _annualRate = ratesTable.matrix[(ratesTable.rows - 1)][2];
            } else {
                for (int i = 0; i < (ratesTable.rows - 1); i++)
                {
                    if (investedAmount >= ratesTable.matrix[i][0] && investedAmount <= ratesTable.matrix[i][1])
                    {
                        _annualRate = ratesTable.matrix[i][2];
                    }
                }
            }

            for (int i = 1; i <= totalTerms; i++)
            {
                totalProductions += investedAmount * (_annualRate / 360);
            }
            dto.AnnualRate = _annualRate;
            dto.TotalProductions = _totalProductions;
        }
    }
}
