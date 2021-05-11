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
    public partial class EditClientDebtForm : Form, IEditClientDebtForm
    {
        private IMainController mainController = null;
        private ClientDebt currentClientDebt = null;

        public EditClientDebtForm()
        {
            InitializeComponent();
        }

        public void ShowModal(IMainController mainController, ClientDebt clientDebt)
        {
            this.mainController = mainController;
            currentClientDebt = clientDebt;

            btnConfirm.Enabled = false;

            UpdateData();

            ShowDialog();
        }

        private void UpdateData()
        {
            List<object> data = new List<object>();
            data.Add(new
            {
                Value = currentClientDebt,
                Display = currentClientDebt.ClientInDebt.FirstName + " "
                + currentClientDebt.ClientInDebt.LastName + " ("
                + currentClientDebt.ClientInDebt.Oib + ")"
            });

            comboBoxClientInDebt.ValueMember = "Value";
            comboBoxClientInDebt.DisplayMember = "Display";
            comboBoxClientInDebt.DataSource = data;

            comboBoxClientInDebt.Enabled = false;

            numericUpDownAmount.Value = currentClientDebt.Amount;

            textBoxDescription.Text = currentClientDebt.Description;
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
            return numericUpDownAmount.Value > 0
                    && !string.IsNullOrEmpty(textBoxDescription.Text);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (IsBtnConfirmEnabled())
            {
                try
                {
                    mainController.EditClientDebtWithId(currentClientDebt.DebtId,
                    new ClientDebt(currentClientDebt.ClientInDebt,
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