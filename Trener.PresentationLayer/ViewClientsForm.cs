using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trener.BaseLib;
using Trener.Model;

namespace Trener.PresentationLayer
{
    public partial class ViewClientsForm : Form, IViewClientsForm, IObserver
    {
        private IMainController mainController = null;
        private List<Client> clients = null;

        public ViewClientsForm()
        {
            InitializeComponent();
        }

        public void ShowModaless(IMainController mainController, List<Client> clients)
        {
            this.mainController = mainController;
            this.clients = clients;

            btnEditClient.Enabled = false;
            btnRemoveClient.Enabled = false;

            UpdateList(clients);

            Show();
        }

        public string GetName()
        {
            return "ViewClientsForm";
        }

        public void UpdateForm(Dictionary<string, List<object>> newData)
        {
            if (newData.ContainsKey("clients"))
            {
                List<Client> newClients = newData["clients"].Cast<Client>().ToList(); ;
                UpdateList(newClients);
            }
        }

        private void UpdateList(List<Client> newClients)
        {
            listClients.Items.Clear();

            foreach (Client client in newClients)
            {
                string oib = client.Oib;
                string firstName = client.FirstName;
                string lastName = client.LastName;
                DateTime dateOfBirth = client.DateOfBirth;
                string phoneNumber = client.PhoneNumber;
                DateTime dateOfJoining = client.DateOfJoining;

                FitnessLevel fitnessLevel = client.FitnessLevel;
                FieldInfo fi = fitnessLevel.GetType().GetField(fitnessLevel.ToString());
                DescriptionAttribute[] attributes =
                        (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
                string fitnessLevelString = attributes[0].Description;

                string notes = client.Notes;
                List<TrainingGroup> inTrainingGroups = client.InTrainingGroups;

                ListViewItem listItem = new ListViewItem(oib);
                listItem.SubItems.Add(firstName);
                listItem.SubItems.Add(lastName);
                listItem.SubItems.Add(dateOfBirth.ToString("d", CultureInfo.CreateSpecificCulture("hr-HR")));
                listItem.SubItems.Add(phoneNumber);
                listItem.SubItems.Add(dateOfJoining.ToString("d", CultureInfo.CreateSpecificCulture("hr-HR")));
                listItem.SubItems.Add(fitnessLevelString);
                listItem.SubItems.Add(notes);
                listItem.SubItems.Add(string.Join(", ", inTrainingGroups.Select(group => group.Name)));

                listClients.Items.Add(listItem);
            }
        }

        private void listClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditClient.Enabled = listClients.SelectedItems.Count > 0;
            btnRemoveClient.Enabled = listClients.SelectedItems.Count > 0;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            mainController.ShowAddClient();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (listClients.SelectedItems.Count > 0)
            {
                string oib = listClients.SelectedItems[0].Text;
                mainController.ShowEditClient(oib);
            }
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            if (listClients.SelectedItems.Count > 0)
            {
                try
                {
                    string oib = listClients.SelectedItems[0].Text;
                    mainController.RemoveClientWithOib(oib);
                }
                catch (DependantDataNotDeletableException)
                {
                    MessageBox.Show("Klijent se ne može obrisati jer ima dugovanja", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ViewClientsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainController.DeleteObserver(this);
        }
    }
}