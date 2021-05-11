using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trener.PresentationLayer;
using Trener.Controllers;
using Trener.DataAccessLayer;

namespace Trener.AppStarter
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            FormFactory formFactory = new FormFactory();

            MainController mainController = new MainController(formFactory,
                ClientDebtRepository.GetInstance(), ClientRepository.GetInstance(),
                ExerciseRepository.GetInstance(), TrainingGroupRepository.GetInstance(),
                TrainingPeriodRepository.GetInstance(), TrainingRepository.GetInstance());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(mainController));
        }
    }
}