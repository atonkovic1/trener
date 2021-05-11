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
    public partial class ViewExercisesForm : Form, IViewExercisesForm, IObserver
    {
        private IMainController mainController = null;
        private List<Exercise> exercises = null;

        public ViewExercisesForm()
        {
            InitializeComponent();
        }

        public void ShowModaless(IMainController mainController, List<Exercise> exercises)
        {
            this.mainController = mainController;
            this.exercises = exercises;

            btnEditExercise.Enabled = false;
            btnRemoveExercise.Enabled = false;

            UpdateList(exercises);

            Show();
        }

        public string GetName()
        {
            return "ViewExercisesForm";
        }

        public void UpdateForm(Dictionary<string, List<object>> newData)
        {
            if (newData.ContainsKey("exercises"))
            {
                List<Exercise> newExercises = newData["exercises"].Cast<Exercise>().ToList(); ;
                UpdateList(newExercises);
            }
        }

        private void UpdateList(List<Exercise> newExercises)
        {
            listExercises.Items.Clear();

            foreach (Exercise exercise in newExercises)
            {
                string name = exercise.Name;

                FitnessLevel requiredFitnessLevel = exercise.RequiredFitnessLevel;
                FieldInfo fi = requiredFitnessLevel.GetType().GetField(requiredFitnessLevel.ToString());
                DescriptionAttribute[] attributes =
                        (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
                string requiredFitnessLevelString = attributes[0].Description;

                string description = exercise.Description;

                ListViewItem listItem = new ListViewItem(name);
                listItem.SubItems.Add(requiredFitnessLevelString);
                listItem.SubItems.Add(description);

                listExercises.Items.Add(listItem);
            }
        }

        private void listExercises_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditExercise.Enabled = listExercises.SelectedItems.Count > 0;
            btnRemoveExercise.Enabled = listExercises.SelectedItems.Count > 0;
        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            mainController.ShowAddExercise();
        }

        private void btnEditExercise_Click(object sender, EventArgs e)
        {
            if (listExercises.SelectedItems.Count > 0)
            {
                string exerciseName = listExercises.SelectedItems[0].Text;
                mainController.ShowEditExercise(exerciseName);
            }
        }

        private void btnRemoveExercise_Click(object sender, EventArgs e)
        {
            if (listExercises.SelectedItems.Count > 0)
            {
                try
                {
                    string exerciseName = listExercises.SelectedItems[0].Text;
                    mainController.RemoveExerciseWithName(exerciseName);
                }
                catch (DependantDataNotDeletableException)
                {
                    MessageBox.Show("Vježba se ne može obrisati jer postoji trening koji je sadrži", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ViewExercisesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainController.DeleteObserver(this);
        }
    }
}