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
    public partial class ViewTrainingsForm : Form, IViewTrainingsForm, IObserver
    {
        private IMainController mainController = null;
        private List<Training> trainings = null;

        public ViewTrainingsForm()
        {
            InitializeComponent();
        }

        public void ShowModaless(IMainController mainController, List<Training> trainings)
        {
            this.mainController = mainController;
            this.trainings = trainings;

            btnEditTraining.Enabled = false;
            btnRemoveTraining.Enabled = false;

            UpdateList(trainings);

            Show();
        }

        public string GetName()
        {
            return "ViewTrainingsForm";
        }

        public void UpdateForm(Dictionary<string, List<object>> newData)
        {
            if (newData.ContainsKey("trainings"))
            {
                List<Training> newTrainings = newData["trainings"].Cast<Training>().ToList(); ;
                UpdateList(newTrainings);
            }
        }

        private void UpdateList(List<Training> newTraining)
        {
            listTrainings.Items.Clear();

            foreach (Training training in newTraining)
            {
                string name = training.Name;

                FitnessLevel requiredFitnessLevel = training.RequiredFitnessLevel;
                FieldInfo fi = requiredFitnessLevel.GetType().GetField(requiredFitnessLevel.ToString());
                DescriptionAttribute[] attributes =
                        (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
                string requiredFitnessLevelString = attributes[0].Description;

                List<Exercise> exercises = training.Exercises;

                ListViewItem listItem = new ListViewItem(name);
                listItem.SubItems.Add(requiredFitnessLevelString);
                listItem.SubItems.Add(String.Join(", ", exercises.Select(exercise => exercise.Name)));

                listTrainings.Items.Add(listItem);
            }
        }

        private void listTrainings_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditTraining.Enabled = listTrainings.SelectedItems.Count > 0;
            btnRemoveTraining.Enabled = listTrainings.SelectedItems.Count > 0;
        }

        private void btnAddTraining_Click(object sender, EventArgs e)
        {
            mainController.ShowAddTraining();
        }

        private void btnEditTraining_Click(object sender, EventArgs e)
        {
            if (listTrainings.SelectedItems.Count > 0)
            {
                string trainingName = listTrainings.SelectedItems[0].Text;
                mainController.ShowEditTraining(trainingName);
            }
        }

        private void btnRemoveTraining_Click(object sender, EventArgs e)
        {
            if (listTrainings.SelectedItems.Count > 0)
            {
                try
                {
                    string trainingName = listTrainings.SelectedItems[0].Text;
                    mainController.RemoveTrainingWithName(trainingName);
                }
                catch (DependantDataNotDeletableException)
                {
                    MessageBox.Show("Trening se ne može obrisati jer postoji grupa koja ga vježba", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ViewTrainingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainController.DeleteObserver(this);
        }
    }
}