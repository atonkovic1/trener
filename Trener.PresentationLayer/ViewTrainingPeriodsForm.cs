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
    public partial class ViewTrainingPeriodsForm : Form, IViewTrainingPeriodsForm, IObserver
    {
        private IMainController mainController = null;
        private List<TrainingPeriod> trainingPeriods = null;

        public ViewTrainingPeriodsForm()
        {
            InitializeComponent();
        }

        public void ShowModaless(IMainController mainController, List<TrainingPeriod> trainingPeriods)
        {
            this.mainController = mainController;
            this.trainingPeriods = trainingPeriods;

            btnEditTrainingPeriod.Enabled = false;
            btnRemoveTrainingPeriod.Enabled = false;

            UpdateList(trainingPeriods);

            Show();
        }

        public string GetName()
        {
            return "ViewTrainingPeriodsForm";
        }

        public void UpdateForm(Dictionary<string, List<object>> newData)
        {
            if (newData.ContainsKey("trainingPeriods"))
            {
                List<TrainingPeriod> newTrainingPeriods = newData["trainingPeriods"].Cast<TrainingPeriod>().ToList(); ;
                UpdateList(newTrainingPeriods);
            }
        }

        private void UpdateList(List<TrainingPeriod> newTrainingPeriods)
        {
            listTrainingPeriods.Items.Clear();

            foreach (TrainingPeriod trainingPeriod in newTrainingPeriods)
            {
                int id = trainingPeriod.PeriodId;

                DayOfWeek dayOfWeek = trainingPeriod.DayOfWeek;
                string dayOfWeekString = new CultureInfo("hr-HR").DateTimeFormat.GetDayName(dayOfWeek);
                dayOfWeekString = dayOfWeekString.Substring(0, 1).ToUpper() + dayOfWeekString.Substring(1);

                TimeSpan periodStart = trainingPeriod.PeriodStart;
                TimeSpan periodEnd = trainingPeriod.PeriodEnd;

                ListViewItem listItem = new ListViewItem(id.ToString());
                listItem.SubItems.Add(dayOfWeekString);
                listItem.SubItems.Add(periodStart.ToString(@"hh\:mm"));
                listItem.SubItems.Add(periodEnd.ToString(@"hh\:mm"));

                listTrainingPeriods.Items.Add(listItem);
            }
        }

        private void listTrainingPeriods_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditTrainingPeriod.Enabled = listTrainingPeriods.SelectedItems.Count > 0;
            btnRemoveTrainingPeriod.Enabled = listTrainingPeriods.SelectedItems.Count > 0;
        }

        private void btnAddTrainingPeriod_Click(object sender, EventArgs e)
        {
            mainController.ShowAddTrainingPeriod();
        }

        private void btnEditTrainingPeriod_Click(object sender, EventArgs e)
        {
            if (listTrainingPeriods.SelectedItems.Count > 0)
            {
                int periodId = int.Parse(listTrainingPeriods.SelectedItems[0].Text);
                mainController.ShowEditTrainingPeriod(periodId);
            }
        }

        private void btnRemoveTrainingPeriod_Click(object sender, EventArgs e)
        {
            if (listTrainingPeriods.SelectedItems.Count > 0)
            {
                try
                {
                    int periodId = int.Parse(listTrainingPeriods.SelectedItems[0].Text);
                    mainController.RemoveTrainingPeriodWithId(periodId);
                }
                catch (DependantDataNotDeletableException)
                {
                    MessageBox.Show("Termin se ne može obrisati jer postoji grupa koja tada ima trening", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ViewTrainingPeriodsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainController.DeleteObserver(this);
        }
    }
}