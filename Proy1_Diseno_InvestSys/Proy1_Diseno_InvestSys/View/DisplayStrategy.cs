using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.View
{
    public abstract class DisplayStrategy
    {
        protected Controller.Controller controller;

        public DisplayStrategy() {
            controller = Controller.Controller.getInstance();
        }
    }
}
