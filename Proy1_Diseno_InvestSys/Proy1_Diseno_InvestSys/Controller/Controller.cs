using Proy1_Diseno_InvestSys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.Controller
{
    public class Controller {
        private static Controller instance;
        private DTOData dto;
        private Logger xmlLogger;
        private Logger csvLogger;

        private Controller() {
            this.dto = new DTOData();
            xmlLogger = new XMLLogger();
            csvLogger = new CSVLogger();
        }

        public static Controller getInstance() {
            if (instance == null) instance = new Controller();
            return instance;
        }

        public DTOData DTO {
            get { return this.dto; }
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
            createRatesTable();
            InvSystem invSystem;
            if (dto.InvestmentSystem == InvestmentType.AGREEDRATE) invSystem = new AgreedRate(dto.Name, dto.InvestedAmount, dto.TotalTerms, dto.Currency, dto.RatesTable);
            else if (dto.InvestmentSystem == InvestmentType.CURRENT) invSystem = new Current(dto.Name, dto.InvestedAmount, dto.TotalTerms, dto.Currency, dto.RatesTable);
            else if (dto.InvestmentSystem == InvestmentType.TERMDEPOSIT) invSystem = new TermDeposit(dto.Name, dto.InvestedAmount, dto.TotalTerms, dto.Currency, dto.RatesTable);
            else {
                throw new Exception("Invalid investment type");
            }
            invSystem.calculateProduction();
            xmlLogger.log(dto.ToString());
            csvLogger.log(dto.ToString());
        }

        public List<string> getCurrencies() {
            return Enum.GetNames(typeof(Currency)).ToList();
        }

        public List<string> getInvestments() {
            return Enum.GetNames(typeof(InvestmentType)).ToList();
        }
    }
}
