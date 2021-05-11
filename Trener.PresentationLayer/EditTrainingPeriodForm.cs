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
    public partial class EditTrainingPeriodForm : Form, IEditTrainingPeriodForm
    {
        private IMainController mainController = null;
        private TrainingPeriod currentTrainingPeriod = null;

        public EditTrainingPeriodForm()
        {
            InitializeComponent();
        }

        private void EditTrainingPeriodForm_Load(object sender, EventArgs e)
        {
            dtpPeriodStart.Value = DateTime.Today + currentTrainingPeriod.PeriodStart;
            dtpPeriodEnd.Value = DateTime.Today + currentTrainingPeriod.PeriodEnd;
        }

        public void ShowModal(IMainController mainController, TrainingPeriod trainingPeriod)
        {
            this.mainController = mainController;
            currentTrainingPeriod = trainingPeriod;

            btnConfirm.Enabled = false;

            UpdateList();

            ShowDialog();
        }

        private void UpdateList()
        {
            var data = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>()
                        .Select(dayOfWeek =>
                        {
                            string dayOfWeekString = new CultureInfo("hr-HR").DateTimeFormat.GetDayName(dayOfWeek);
                            dayOfWeekString = dayOfWeekString.Substring(0, 1).ToUpper() + dayOfWeekString.Substring(1);

                            return new { Value = dayOfWeek, Display = dayOfWeekString };
                        }
                        ).ToList();

            comboBoxDayOfWeek.ValueMember = "Value";
            comboBoxDayOfWeek.DisplayMember = "Display";
            comboBoxDayOfWeek.DataSource = data;

            comboBoxDayOfWeek.SelectedValue = currentTrainingPeriod.DayOfWeek;
        }

        private void comboBoxDayOfWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = comboBoxDayOfWeek.SelectedIndex != -1;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (comboBoxDayOfWeek.SelectedIndex != -1)
            {
                try
                {
                    object comboBoxItem = comboBoxDayOfWeek.SelectedItem;

                    DayOfWeek dayOfWeek = (DayOfWeek)comboBoxItem
                                                    .GetType().GetProperty("Value")
                                                    .GetValue(comboBoxItem, null);

                    mainController.EditTrainingPeriodWithId(currentTrainingPeriod.PeriodId,
                        new TrainingPeriod(dayOfWeek, dtpPeriodStart.Value.TimeOfDay,
                                        dtpPeriodEnd.Value.TimeOfDay));

                    DialogResult = DialogResult.OK;
                }
                catch (IncompleteDataException)
                {
                    MessageBox.Show("Nepotpuni ili neispravni podaci", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (PeriodAlreadyTakenException)
                {
                    MessageBox.Show("Već postoji termin u odabranom vremenu", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}