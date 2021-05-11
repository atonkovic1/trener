using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trener.BaseLib;
using Trener.Model;
using Trener.Model.Repositories;

namespace Trener.Controllers
{
    public class TrainingPeriodController
    {
        public void ShowTrainingPeriods(IViewTrainingPeriodsForm form, ITrainingPeriodRepository trainingPeriodRepository,
                                        IMainController mainController)
        {
            List<TrainingPeriod> trainingPeriods = trainingPeriodRepository.GetAllTrainingPeriods();

            Subject subject = (Subject)trainingPeriodRepository;
            subject.Attach((IObserver)form);

            form.ShowModaless(mainController, trainingPeriods);
        }

        public void ShowAddTrainingPeriod(IFormFactory formFactory,
                                            IMainController mainController)
        {
            IAddTrainingPeriodForm form = formFactory.CreateAddTrainingPeriodForm();

            form.ShowModal(mainController);
        }

        public void ShowEditTrainingPeriod(IFormFactory formFactory,
                                        ITrainingPeriodRepository trainingPeriodRepository,
                                        int periodId,
                                        IMainController mainController)
        {
            IEditTrainingPeriodForm form = formFactory.CreateEditTrainingPeriodForm();

            TrainingPeriod trainingPeriod = trainingPeriodRepository.GetTrainingPeriodWithId(periodId);

            form.ShowModal(mainController, trainingPeriod);
        }

        public void AddTrainingPeriod(TrainingPeriod trainingPeriod, ITrainingPeriodRepository trainingPeriodRepository)
        {
            try
            {
                trainingPeriodRepository.AddTrainingPeriod(trainingPeriod);
            }
            catch (PeriodAlreadyTakenException periodEx)
            {
                throw periodEx;
            }
        }

        public void EditTrainingPeriodWithId(int periodId, TrainingPeriod trainingPeriod,
            ITrainingPeriodRepository trainingPeriodRepository)
        {
            try
            {
                trainingPeriodRepository.EditTrainingPeriodWithId(periodId, trainingPeriod);
            }
            catch (PeriodAlreadyTakenException periodEx)
            {
                throw periodEx;
            }
        }

        public void RemoveTrainingPeriodWithId(int periodId, ITrainingPeriodRepository trainingPeriodRepository, ITrainingGroupRepository trainingGroupRepository)
        {
            List<TrainingGroup> trainingGroups = trainingGroupRepository.GetAllTrainingGroups();

            if (!trainingGroups.Any(group =>
                group.TrainingPeriods.FindIndex(period =>
                    period.PeriodId == periodId) != -1))
            {
                trainingPeriodRepository.RemoveTrainingPeriodWithId(periodId);
            }
            else
            {
                throw new DependantDataNotDeletableException();
            }
        }
    }
}