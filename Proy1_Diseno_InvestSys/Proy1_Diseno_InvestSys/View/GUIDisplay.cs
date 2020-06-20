using Proy1_Diseno_InvestSys.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proy1_Diseno_InvestSys.View
{
    class GUIDisplay : DisplayStrategy
    {
        private GUI gui;

        public GUIDisplay() : base() {
            gui = new GUI(controller);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GUIDisplay guiShow = new GUIDisplay();            
            Application.Run(guiShow.gui);
        }
    }
}
