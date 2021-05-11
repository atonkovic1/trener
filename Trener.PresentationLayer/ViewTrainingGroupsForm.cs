using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trener.BaseLib;
using Trener.Model;

namespace Trener.PresentationLayer
{
    public partial class ViewTrainingGroupsForm : Form, IViewTrainingGroupsForm, IObserver
    {
        private IMainController mainController = null;
        private List<TrainingGroup> trainingGroups = null;

        public ViewTrainingGroupsForm()
        {
            InitializeComponent();
        }

        public void ShowModaless(IMainController mainController, List<TrainingGroup> trainingGroups)
        {
            this.mainController = mainController;
            this.trainingGroups = trainingGroups;

            btnEditTrainingGroup.Enabled = false;
            btnRemoveTrainingGroup.Enabled = false;

            UpdateList(trainingGroups);

            Show();
        }

        public string GetName()
        {
            return "ViewTrainingGroupsForm";
        }

        public void UpdateForm(Dictionary<string, List<object>> newData)
        {
            if (newData.ContainsKey("trainingGroups"))
            {
                List<TrainingGroup> newTrainingGroups = newData["trainingGroups"].Cast<TrainingGroup>().ToList(); ;
                UpdateList(newTrainingGroups);
            }
        }

        private void UpdateList(List<TrainingGroup> newTrainingGroups)
        {
            listTrainingGroups.Items.Clear();

            foreach (TrainingGroup trainingGroup in newTrainingGroups)
            {
                string name = trainingGroup.Name;
                Training training = trainingGroup.Training;
                List<TrainingPeriod> trainingPeriods = trainingGroup.TrainingPeriods;
                decimal monthlyPrice = trainingGroup.MonthlyPrice;

                ListViewItem listItem = new ListViewItem(name);
                listItem.SubItems.Add(training.Name);
                listItem.SubItems.Add(String.Join(", ", trainingPeriods.Select(trainingPeriod =>
                {
                    string dayOfWeekString = new CultureInfo("hr-HR").DateTimeFormat.GetDayName(trainingPeriod.DayOfWeek);
                    dayOfWeekString = dayOfWeekString.Substring(0, 1).ToUpper() + dayOfWeekString.Substring(1);

                    string periodStartString = trainingPeriod.PeriodStart.ToString(@"hh\:mm");
                    string periodEndString = trainingPeriod.PeriodEnd.ToString(@"hh\:mm");

                    return dayOfWeekString + " " + periodStartString + "-" + periodEndString;
                })));
                listItem.SubItems.Add(monthlyPrice.ToString() + " kn");

                listTrainingGroups.Items.Add(listItem);
            }
        }

        private void listTrainingGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditTrainingGroup.Enabled = listTrainingGroups.SelectedItems.Count > 0;
            btnRemoveTrainingGroup.Enabled = listTrainingGroups.SelectedItems.Count > 0;
        }

        private void btnAddTrainingGroup_Click(object sender, EventArgs e)
        {
            mainController.ShowAddTrainingGroup();
        }

        private void btnEditTrainingGroup_Click(object sender, EventArgs e)
        {
            if (listTrainingGroups.SelectedItems.Count > 0)
            {
                string groupName = listTrainingGroups.SelectedItems[0].Text;
                mainController.ShowEditTrainingGroup(groupName);
            }
        }

        private void btnRemoveTrainingGroup_Click(object sender, EventArgs e)
        {
            if (listTrainingGroups.SelectedItems.Count > 0)
            {
                try
                {
                    string groupName = listTrainingGroups.SelectedItems[0].Text;
                    mainController.RemoveTrainingGroupWithName(groupName);
                }
                catch (DependantDataNotDeletableException)
                {
                    MessageBox.Show("Grupa se ne može obrisati jer ima članove", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ViewTrainingGroupsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainController.DeleteObserver(this);
        }
    }
}