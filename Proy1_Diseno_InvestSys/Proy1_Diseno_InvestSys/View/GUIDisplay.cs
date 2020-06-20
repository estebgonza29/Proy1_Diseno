using Proy1_Diseno_InvestSys.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.View
{
    class GUIDisplay : DisplayStrategy
    {
        private GUI gui;

        public GUIDisplay() : base() {
            gui = new GUI(controller);
            gui.Show();
        }

        public int main() {
            
            return 0;
        }
    }
}
