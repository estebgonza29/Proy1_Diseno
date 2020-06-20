using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proy1_Diseno_InvestSys.View
{
    public partial class GUI : Form
    {
        private Controller.Controller controller;
        public GUI(Controller.Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            List<string> currencies = controller.getCurrencies();
            List<string> investments = controller.getInvestments();
            for (int i = 0; i < currencies.Count; i++) cmBoxCurrency.Items.Add(currencies.ElementAt(i));
            for (int i = 0; i < investments.Count; i++) cmBoxInvSystem.Items.Add(investments.ElementAt(i));
        }

        private void GUIDisplay_Load(object sender, EventArgs e)
        {
            
        }

        public void cmBoxTerms_TextChanged(object sender, EventArgs e)
        {

        }

        public string TxtName {
            get { return this.txtName.Text; }
            set { this.txtName.Text = value; }
        }

        public string TxtInvAmount {
            get { return this.txtInvAmount.Text; }
            set { this.txtInvAmount.Text = value; }
        }

        public string TxtTerms {
            get { return this.txtTerms.Text; }
            set { this.txtTerms.Text = value; }
        }

        public string TxtRes {
            get { return this.txtRes.Text; }
            set { this.txtRes.Text = value; }
        }

        public ComboBox.ObjectCollection CmBoxCurrency {
            get { return this.cmBoxCurrency.Items; }
        }

        public void AddCurrency(string element) {
            this.cmBoxCurrency.Items.Add(element);
        }

        public ComboBox.ObjectCollection CmBoxInvSystem {
            get { return this.cmBoxInvSystem.Items; }
        }

        public void AddInvSystem(string element) {
            this.cmBoxInvSystem.Items.Add(element);
        }
    }
}
