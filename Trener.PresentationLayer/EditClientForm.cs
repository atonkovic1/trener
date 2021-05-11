using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trener.BaseLib;
using Trener.Model;

namespace Trener.PresentationLayer
{
    public partial class EditClientForm : Form, IEditClientForm
    {
        private IMainController mainController = null;
        private Client currentClient = null;
        private List<TrainingGroup> trainingGroups = null;

        public EditClientForm()
        {
            InitializeComponent();
        }

        public void ShowModal(IMainController mainController, Client client, List<TrainingGroup> trainingGroups)
        {
            this.mainController = mainController;
            currentClient = client;
            this.trainingGroups = trainingGroups;

            btnConfirm.Enabled = false;

            UpdateLists();

            ShowDialog();
        }

        private void UpdateLists()
        {
            var data1 = Enum.GetValues(typeof(FitnessLevel)).Cast<FitnessLevel>()
                        .Select(fitnessLevel =>
                        {
                            FieldInfo fi = fitnessLevel.GetType().GetField(fitnessLevel.ToString());
                            DescriptionAttribute[] attributes =
                                    (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
                            string fitnessLevelString = attributes[0].Description;

                            return new { Value = fitnessLevel, Display = fitnessLevelString };
                        }
                        ).ToList();

            comboBoxFitnessLvl.ValueMember = "Value";
            comboBoxFitnessLvl.DisplayMember = "Display";
            comboBoxFitnessLvl.DataSource = data1;

            var data2 = trainingGroups.Select(trainingGroup =>
                new { Value = trainingGroup, Display = trainingGroup.Name }).ToList();

            listBoxGroups.ValueMember = "Value";
            listBoxGroups.DisplayMember = "Display";
            listBoxGroups.DataSource = data2;

            textBoxOib.Text = currentClient.Oib;
            textBoxFirstName.Text = currentClient.FirstName;
            textBoxLastName.Text = currentClient.LastName;
            dtpDateOfBirth.Value = currentClient.DateOfBirth;
            textBoxPhoneNum.Text = currentClient.PhoneNumber;
            dtpDateOfJoining.Value = currentClient.DateOfJoining;
            comboBoxFitnessLvl.SelectedValue = currentClient.FitnessLevel;
            textBoxNotes.Text = currentClient.Notes;

            if (currentClient.InTrainingGroups.Count > 0)
            {
                listBoxGroups.SetSelected(0, false);

                foreach (TrainingGroup group in currentClient.InTrainingGroups)
                {
                    int index = trainingGroups.FindIndex(trainingGroup =>
                                                trainingGroup.Name == group.Name);

                    listBoxGroups.SetSelected(index, true);
                }
            }
        }

        private void textBoxOib_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private void textBoxPhoneNum_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private void comboBoxFitnessLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private void checkedListBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private bool IsBtnConfirmEnabled()
        {
            return !string.IsNullOrEmpty(textBoxOib.Text)
                    && !string.IsNullOrEmpty(textBoxFirstName.Text)
                    && !string.IsNullOrEmpty(textBoxLastName.Text)
                    && !string.IsNullOrEmpty(textBoxPhoneNum.Text)
                    && comboBoxFitnessLvl.SelectedIndex != -1
                    && listBoxGroups.SelectedItems.Count > 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (IsBtnConfirmEnabled())
            {
                try
                {
                    List<TrainingGroup> selectedGroups = new List<TrainingGroup>();

                    foreach (object item in listBoxGroups.SelectedItems)
                    {
                        TrainingGroup group = (TrainingGroup)item.GetType()
                                                .GetProperty("Value")
                                                .GetValue(item, null);
                        selectedGroups.Add(group);
                    }

                    object comboBoxItem = comboBoxFitnessLvl.SelectedItem;

                    FitnessLevel fitnessLevel = (FitnessLevel)comboBoxItem
                                                    .GetType().GetProperty("Value")
                                                    .GetValue(comboBoxItem, null);

                    mainController.EditClientWithOib(currentClient.Oib,
                        new Client(textBoxOib.Text, textBoxFirstName.Text, textBoxLastName.Text,
                                    dtpDateOfBirth.Value, textBoxPhoneNum.Text,
                                    dtpDateOfJoining.Value, fitnessLevel,
                                    textBoxNotes.Text, selectedGroups));

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