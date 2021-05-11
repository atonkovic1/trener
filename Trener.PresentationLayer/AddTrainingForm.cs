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
    public partial class AddTrainingForm : Form, IAddTrainingForm
    {
        private IMainController mainController = null;
        private List<Exercise> exercises = null;

        public AddTrainingForm()
        {
            InitializeComponent();
        }

        public void ShowModal(IMainController mainController, List<Exercise> exercises)
        {
            this.mainController = mainController;
            this.exercises = exercises;

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

            var data2 = exercises.Select(exercise =>
                new { Value = exercise, Display = exercise.Name }).ToList();

            listBoxExercises.ValueMember = "Value";
            listBoxExercises.DisplayMember = "Display";
            listBoxExercises.DataSource = data2;
        }

        private void textBoxTrainingName_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private void comboBoxFitnessLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private void listBoxExercises_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private bool IsBtnConfirmEnabled()
        {
            return !string.IsNullOrEmpty(textBoxTrainingName.Text)
                    && comboBoxFitnessLvl.SelectedIndex != -1
                    && listBoxExercises.SelectedItems.Count > 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (IsBtnConfirmEnabled())
            {
                try
                {
                    object comboBoxItem = comboBoxFitnessLvl.SelectedItem;

                    FitnessLevel fitnessLevel = (FitnessLevel)comboBoxItem
                                                   .GetType().GetProperty("Value")
                                                   .GetValue(comboBoxItem, null);

                    List<Exercise> selectedExercises = new List<Exercise>();

                    foreach (object item in listBoxExercises.SelectedItems)
                    {
                        Exercise exercise = (Exercise)item.GetType()
                                                .GetProperty("Value")
                                                .GetValue(item, null);
                        selectedExercises.Add(exercise);
                    }

                    mainController.AddTraining(
                        new Training(textBoxTrainingName.Text, fitnessLevel,
                                        selectedExercises));

                    DialogResult = DialogResult.OK;
                }
                catch (IncompleteDataException)
                {
                    MessageBox.Show("Nepotpuni ili neispravni podaci", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NameAlreadyTakenException)
                {
                    MessageBox.Show("Trening s unesenim nazivom već postoji", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}