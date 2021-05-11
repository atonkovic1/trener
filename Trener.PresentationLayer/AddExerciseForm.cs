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
    public partial class AddExerciseForm : Form, IAddExerciseForm
    {
        private IMainController mainController = null;

        public AddExerciseForm()
        {
            InitializeComponent();
        }

        public void ShowModal(IMainController mainController)
        {
            this.mainController = mainController;

            btnConfirm.Enabled = false;

            UpdateList();

            ShowDialog();
        }

        private void UpdateList()
        {
            var data = Enum.GetValues(typeof(FitnessLevel)).Cast<FitnessLevel>()
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
            comboBoxFitnessLvl.DataSource = data;
        }

        private void textBoxExerciseName_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private void comboBoxFitnessLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private void textBoxExerciseDescription_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = IsBtnConfirmEnabled();
        }

        private bool IsBtnConfirmEnabled()
        {
            return !string.IsNullOrEmpty(textBoxExerciseName.Text)
                    && !string.IsNullOrEmpty(textBoxExerciseDescription.Text)
                    && comboBoxFitnessLvl.SelectedIndex != -1;
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

                    mainController.AddExercise(
                        new Exercise(textBoxExerciseName.Text, fitnessLevel,
                                        textBoxExerciseDescription.Text));

                    DialogResult = DialogResult.OK;
                }
                catch (IncompleteDataException)
                {
                    MessageBox.Show("Nepotpuni ili neispravni podaci", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NameAlreadyTakenException)
                {
                    MessageBox.Show("Vježba s unesenim nazivom već postoji", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}