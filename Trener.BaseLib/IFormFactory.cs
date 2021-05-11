using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trener.Model;

namespace Trener.BaseLib
{
    public interface IFormFactory
    {
        IViewClientsForm CreateViewClientsForm();

        IAddClientForm CreateAddClientForm();

        IEditClientForm CreateEditClientForm();

        IViewClientDebtsForm CreateViewClientDebtsForm();

        IAddClientDebtForm CreateAddClientDebtForm();

        IEditClientDebtForm CreateEditClientDebtForm();

        IViewTrainingGroupsForm CreateViewTrainingGroupsForm();

        IAddTrainingGroupForm CreateAddTrainingGroupForm();

        IEditTrainingGroupForm CreateEditTrainingGroupForm();

        IViewTrainingPeriodsForm CreateViewTrainingPeriodsForm();

        IAddTrainingPeriodForm CreateAddTrainingPeriodForm();

        IEditTrainingPeriodForm CreateEditTrainingPeriodForm();

        IViewTrainingsForm CreateViewTrainingsForm();

        IAddTrainingForm CreateAddTrainingForm();

        IEditTrainingForm CreateEditTrainingForm();

        IViewExercisesForm CreateViewExercisesForm();

        IAddExerciseForm CreateAddExerciseForm();

        IEditExerciseForm CreateEditExerciseForm();
    }
}