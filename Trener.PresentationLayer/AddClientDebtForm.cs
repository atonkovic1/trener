using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trener.BaseLib;
using Trener.Model;

namespace Trener.PresentationLayer
{
    public partial class AddClientDebtForm : Form, IAddClientDebtForm
    {
        private IMainController mainController = null;
        private List<Client> clients = null;

        public AddClientDebtForm()
        {
            InitializeComponent();
        }

        public void ShowModal(IMainController mainController, List<Client> clients)
        {
            this.mainController = mainController;
            this.clients = clients;

            btnConfirm.Enabled = false;

            UpdateList();

            ShowDialog();
        }

        private void UpdateList()
        {
            var data = clients.Select(client =>
                new { Value = client, Display = client.FirstName + " " + client.LastName + " (" + client.Oib + ")" }).ToList();

            comboBoxClientInDebt.ValueMember = "Value";
            comboBoxClientInDebt.DisplayMember = "Display";
            comboBoxClientInDebt.DataSource = data;
        }

        private void comboBoxClientInDebt_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private bool IsBtnConfirmEnabled()
        {
            return comboBoxClientInDebt.SelectedIndex != -1
                    && numericUpDownAmount.Value > 0
                    && !string.IsNullOrEmpty(textBoxDescription.Text);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (IsBtnConfirmEnabled())
            {
                try
                {
                    mainController.AddClientDebt(
                    new ClientDebt(clients.Find(client => client.Oib == ((Client)comboBoxClientInDebt.SelectedValue).Oib),
                        numericUpDownAmount.Value, textBoxDescription.Text));

                    DialogResult = DialogResult.OK;
                }
                catch (IncompleteDataException)
                {
                    MessageBox.Show("Nepotpuni ili neispravni podaci", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}