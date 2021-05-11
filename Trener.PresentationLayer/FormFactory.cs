using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trener.BaseLib;

namespace Trener.PresentationLayer
{
    public class FormFactory : IFormFactory
    {
        public IViewClientsForm CreateViewClientsForm()
        {
            ViewClientsForm form = new ViewClientsForm();

            return form;
        }

        public IAddClientForm CreateAddClientForm()
        {
            AddClientForm form = new AddClientForm();

            return form;
        }

        public IEditClientForm CreateEditClientForm()
        {
            EditClientForm form = new EditClientForm();

            return form;
        }

        public IViewClientDebtsForm CreateViewClientDebtsForm()
        {
            ViewClientDebtsForm form = new ViewClientDebtsForm();

            return form;
        }

        public IAddClientDebtForm CreateAddClientDebtForm()
        {
            AddClientDebtForm form = new AddClientDebtForm();

            return form;
        }

        public IEditClientDebtForm CreateEditClientDebtForm()
        {
            EditClientDebtForm form = new EditClientDebtForm();

            return form;
        }

        public IViewTrainingGroupsForm CreateViewTrainingGroupsForm()
        {
            ViewTrainingGroupsForm form = new ViewTrainingGroupsForm();

            return form;
        }

        public IAddTrainingGroupForm CreateAddTrainingGroupForm()
        {
            AddTrainingGroupForm form = new AddTrainingGroupForm();

            return form;
        }

        public IEditTrainingGroupForm CreateEditTrainingGroupForm()
        {
            EditTrainingGroupForm form = new EditTrainingGroupForm();

            return form;
        }

        public IViewTrainingPeriodsForm CreateViewTrainingPeriodsForm()
        {
            ViewTrainingPeriodsForm form = new ViewTrainingPeriodsForm();

            return form;
        }

        public IAddTrainingPeriodForm CreateAddTrainingPeriodForm()
        {
            AddTrainingPeriodForm form = new AddTrainingPeriodForm();

            return form;
        }

        public IEditTrainingPeriodForm CreateEditTrainingPeriodForm()
        {
            EditTrainingPeriodForm form = new EditTrainingPeriodForm();

            return form;
        }

        public IViewTrainingsForm CreateViewTrainingsForm()
        {
            ViewTrainingsForm form = new ViewTrainingsForm();

            return form;
        }

        public IAddTrainingForm CreateAddTrainingForm()
        {
            AddTrainingForm form = new AddTrainingForm();

            return form;
        }

        public IEditTrainingForm CreateEditTrainingForm()
        {
            EditTrainingForm form = new EditTrainingForm();

            return form;
        }

        public IViewExercisesForm CreateViewExercisesForm()
        {
            ViewExercisesForm form = new ViewExercisesForm();

            return form;
        }

        public IAddExerciseForm CreateAddExerciseForm()
        {
            AddExerciseForm form = new AddExerciseForm();

            return form;
        }

        public IEditExerciseForm CreateEditExerciseForm()
        {
            EditExerciseForm form = new EditExerciseForm();

            return form;
        }
    }
}