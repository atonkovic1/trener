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
    public partial class AddTrainingGroupForm : Form, IAddTrainingGroupForm
    {
        private IMainController mainController = null;
        private List<Training> trainings = null;
        private List<TrainingPeriod> trainingPeriods = null;

        public AddTrainingGroupForm()
        {
            InitializeComponent();
        }

        public void ShowModal(IMainController mainController, List<Training> trainings, List<TrainingPeriod> trainingPeriods)
        {
            this.mainController = mainController;
            this.trainings = trainings;
            this.trainingPeriods = trainingPeriods;

            btnConfirm.Enabled = false;

            UpdateLists();

            ShowDialog();
        }

        private void UpdateLists()
        {
            var data1 = trainings.Select(training =>
                new { Value = training, Display = training.Name }).ToList();

            comboBoxTraining.ValueMember = "Value";
            comboBoxTraining.DisplayMember = "Display";
            comboBoxTraining.DataSource = data1;

            var data2 = trainingPeriods.Select(trainingPeriod =>
            {
                string dayOfWeekString = new CultureInfo("hr-HR").DateTimeFormat.GetDayName(trainingPeriod.DayOfWeek);
                dayOfWeekString = dayOfWeekString.Substring(0, 1).ToUpper() + dayOfWeekString.Substring(1);

                string periodStartString = trainingPeriod.PeriodStart.ToString(@"hh\:mm");
                string periodEndString = trainingPeriod.PeriodEnd.ToString(@"hh\:mm");

                return new
                {
                    Value = trainingPeriod,
                    Display = dayOfWeekString + " " + periodStartString + "-" + periodEndString
                };
            }).ToList();

            listBoxTrainingPeriods.ValueMember = "Value";
            listBoxTrainingPeriods.DisplayMember = "Display";
            listBoxTrainingPeriods.DataSource = data2;
        }

        private void textBoxGroupName_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private void comboBoxTraining_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private void listBoxTrainingPeriods_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private void numericUpDownPrice_ValueChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private bool IsBtnConfirmEnabled()
        {
            return !string.IsNullOrEmpty(textBoxGroupName.Text)
                    && comboBoxTraining.SelectedIndex != -1
                    && listBoxTrainingPeriods.SelectedItems.Count > 0
                    && numericUpDownPrice.Value > 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (IsBtnConfirmEnabled())
            {
                try
                {
                    object comboBoxItem = comboBoxTraining.SelectedItem;

                    Training training = (Training)comboBoxItem
                                        .GetType().GetProperty("Value")
                                        .GetValue(comboBoxItem, null);

                    List<TrainingPeriod> selectedPeriods = new List<TrainingPeriod>();

                    foreach (object item in listBoxTrainingPeriods.SelectedItems)
                    {
                        TrainingPeriod period = (TrainingPeriod)item.GetType()
                                                .GetProperty("Value")
                                                .GetValue(item, null);
                        selectedPeriods.Add(period);
                    }

                    mainController.AddTrainingGroup(
                        new TrainingGroup(textBoxGroupName.Text, training,
                                        selectedPeriods, numericUpDownPrice.Value));

                    DialogResult = DialogResult.OK;
                }
                catch (IncompleteDataException)
                {
                    MessageBox.Show("Nepotpuni ili neispravni podaci", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NameAlreadyTakenException)
                {
                    MessageBox.Show("Grupa s unesenim nazivom već postoji", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}