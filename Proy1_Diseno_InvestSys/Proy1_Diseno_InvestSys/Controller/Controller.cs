using Proy1_Diseno_InvestSys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.Controller
{
    class Controller {
        private Controller instance;
        private DTOData dto { get; }
        private Logger logger;

        private Controller() {
            this.dto = new DTOData();
        }

        public Controller getInstance() {
            if (instance == null) instance = new Controller();
            return instance;
        }

        public void createRatesTable() {
            RateTableBuilder builder = null;
            if (dto.InvestmentSystem == InvestmentType.AGREEDRATE) builder = new AgreeRateBuilder();
            else if (dto.InvestmentSystem == InvestmentType.CURRENT) builder = new CurrentRatesBuilder();
            else if (dto.InvestmentSystem == InvestmentType.TERMDEPOSIT) builder = new TermDepositRatesBuilder();

            try
            {
                RateTableDirector director = new RateTableDirector(builder);
                director.construct();
                dto.RatesTable = director.getTable();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                throw new Exception("Invalid investment type");
            }
        }

        public void calculateProduction() {
            InvSystem invSystem;
            if (dto.InvestmentSystem == InvestmentType.AGREEDRATE) invSystem = new AgreedRate(dto.Name, dto.InvestedAmount, dto.TotalTerms, dto.Currency, dto.RatesTable);
            else if (dto.InvestmentSystem == InvestmentType.CURRENT) invSystem = new Current(dto.Name, dto.InvestedAmount, dto.TotalTerms, dto.Currency, dto.RatesTable);
            else if (dto.InvestmentSystem == InvestmentType.TERMDEPOSIT) invSystem = new TermDeposit(dto.Name, dto.InvestedAmount, dto.TotalTerms, dto.Currency, dto.RatesTable);
            else {
                throw new Exception("Invalid investment type");
            }
            invSystem.calculateProduction();
        }
    }
}
