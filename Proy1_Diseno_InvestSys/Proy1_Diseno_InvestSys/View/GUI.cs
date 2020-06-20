using Proy1_Diseno_InvestSys.Controller;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                if (cmBoxInvSystem.SelectedIndex >= 0)
                {
                    if (txtInvAmount.Text.Length > 0)
                    {
                        if (txtTerms.Text.Length > 0)
                        {
                            if (cmBoxCurrency.SelectedIndex >= 0)
                            {
                                try
                                {
                                    controller.DTO.Name = txtName.Text;
                                    controller.DTO.InvestmentSystem = (InvestmentType)Enum.Parse(typeof(InvestmentType), cmBoxInvSystem.SelectedItem.ToString());
                                    controller.DTO.InvestedAmount = float.Parse(txtInvAmount.Text);
                                    controller.DTO.TotalTerms = int.Parse(txtTerms.Text);
                                    controller.DTO.Currency = (Currency)Enum.Parse(typeof(Currency), cmBoxCurrency.SelectedItem.ToString());
                                    controller.calculateProduction();
                                    txtRes.Text = controller.DTO.ToString();
                                }
                                catch (Exception ex) 
                                {
                                    MessageBox.Show("Error al intentar hacer el cálculo: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else 
                            {
                                MessageBox.Show("Debe seleccionar una moneda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else 
                        {
                            MessageBox.Show("Cantidad de plazos inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Monto mínimo inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else 
                {
                    MessageBox.Show("Debe seleccionar un sistema de inversión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Nombre inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmBoxInvSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
