using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trener.Controllers;

namespace Trener.PresentationLayer
{
    public partial class MainForm : Form
    {
        private MainController mainController;

        public MainForm(MainController mainController)
        {
            this.mainController = mainController;

            this.mainController.LoadDefaultModel();

            InitializeComponent();
        }

        private void btnViewClients_Click(object sender, EventArgs e)
        {
            mainController.ShowClients();
        }

        private void btnViewClientDebts_Click(object sender, EventArgs e)
        {
            mainController.ShowClientDebts();
        }

        private void btnViewTrainingGroups_Click(object sender, EventArgs e)
        {
            mainController.ShowTrainingGroups();
        }

        private void btnViewTrainingPeriods_Click(object sender, EventArgs e)
        {
            mainController.ShowTrainingPeriods();
        }

        private void btnViewTrainings_Click(object sender, EventArgs e)
        {
            mainController.ShowTrainings();
        }

        private void btnViewExercises_Click(object sender, EventArgs e)
        {
            mainController.ShowExercises();
        }
    }
}