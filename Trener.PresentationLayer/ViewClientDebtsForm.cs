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
    public partial class ViewClientDebtsForm : Form, IViewClientDebtsForm, IObserver
    {
        private IMainController mainController = null;
        private List<ClientDebt> clientDebts = null;

        public ViewClientDebtsForm()
        {
            InitializeComponent();
        }

        public void ShowModaless(IMainController mainController, List<ClientDebt> clientDebts)
        {
            this.mainController = mainController;
            this.clientDebts = clientDebts;

            btnEditClientDebt.Enabled = false;
            btnRemoveClientDebt.Enabled = false;

            UpdateList(clientDebts);

            Show();
        }

        public string GetName()
        {
            return "ViewClientDebtsForm";
        }

        public void UpdateForm(Dictionary<string, List<object>> newData)
        {
            if (newData.ContainsKey("clientDebts"))
            {
                List<ClientDebt> newClientDebts = newData["clientDebts"].Cast<ClientDebt>().ToList(); ;
                UpdateList(newClientDebts);
            }
        }

        private void UpdateList(List<ClientDebt> newClientDebts)
        {
            listClientDebts.Items.Clear();

            foreach (ClientDebt clientDebt in newClientDebts)
            {
                int debtId = clientDebt.DebtId;
                string clientFirstName = clientDebt.ClientInDebt.FirstName;
                string clientLastName = clientDebt.ClientInDebt.LastName;
                string clientOib = clientDebt.ClientInDebt.Oib;
                decimal debtAmount = clientDebt.Amount;
                string debtDescription = clientDebt.Description;

                ListViewItem listItem = new ListViewItem(debtId.ToString());
                listItem.SubItems.Add(clientFirstName);
                listItem.SubItems.Add(clientLastName);
                listItem.SubItems.Add(clientOib);
                listItem.SubItems.Add(debtAmount.ToString() + " kn");
                listItem.SubItems.Add(debtDescription);

                listClientDebts.Items.Add(listItem);
            }
        }

        private void listClientDebts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditClientDebt.Enabled = listClientDebts.SelectedItems.Count > 0;
            btnRemoveClientDebt.Enabled = listClientDebts.SelectedItems.Count > 0;
        }

        private void btnAddClientDebt_Click(object sender, EventArgs e)
        {
            mainController.ShowAddClientDebt();
        }

        private void btnEditClientDebt_Click(object sender, EventArgs e)
        {
            if (listClientDebts.SelectedItems.Count > 0)
            {
                int debtId = int.Parse(listClientDebts.SelectedItems[0].Text);
                mainController.ShowEditClientDebt(debtId);
            }
        }

        private void btnRemoveClientDebt_Click(object sender, EventArgs e)
        {
            if (listClientDebts.SelectedItems.Count > 0)
            {
                int debtId = int.Parse(listClientDebts.SelectedItems[0].Text);
                mainController.RemoveClientDebtWithId(debtId);
            }
        }

        private void ViewClientDebtsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainController.DeleteObserver(this);
        }
    }
}