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
    public class TrainingGroupController
    {
        public void ShowTrainingGroups(IViewTrainingGroupsForm form, ITrainingGroupRepository trainingGroupRepository,
                                        IMainController mainController)
        {
            List<TrainingGroup> trainingGroups = trainingGroupRepository.GetAllTrainingGroups();

            Subject subject = (Subject)trainingGroupRepository;
            subject.Attach((IObserver)form);

            form.ShowModaless(mainController, trainingGroups);
        }

        public void ShowAddTrainingGroup(IFormFactory formFactory,
                                    ITrainingGroupRepository trainingGroupRepository,
                                    ITrainingRepository trainingRepository,
                                    ITrainingPeriodRepository trainingPeriodRepository,
                                    IMainController mainController)
        {
            IAddTrainingGroupForm form = formFactory.CreateAddTrainingGroupForm();

            List<Training> trainings = trainingRepository.GetAllTrainings();

            List<TrainingPeriod> trainingPeriods = trainingPeriodRepository.GetAllTrainingPeriods().ToList();

            // Uklanjanje zauzetih termina s popisa dostupnih termina
            foreach (TrainingGroup group in trainingGroupRepository.GetAllTrainingGroups())
            {
                foreach (TrainingPeriod trainingPeriod in group.TrainingPeriods)
                {
                    int index = trainingPeriods.FindIndex(period => period.PeriodId == trainingPeriod.PeriodId);

                    if (index != -1)
                    {
                        trainingPeriods.RemoveAt(index);
                    }
                }
            }

            List<TrainingPeriod> newPeriods = trainingPeriods.Select(item => item).ToList();

            form.ShowModal(mainController, trainings, newPeriods);
        }

        public void ShowEditTrainingGroup(IFormFactory formFactory,
                                        ITrainingGroupRepository trainingGroupRepository,
                                        ITrainingRepository trainingRepository,
                                        ITrainingPeriodRepository trainingPeriodRepository,
                                        string groupName,
                                        IMainController mainController)
        {
            IEditTrainingGroupForm form = formFactory.CreateEditTrainingGroupForm();

            TrainingGroup trainingGroup = trainingGroupRepository.GetTrainingGroupWithName(groupName);

            List<Training> trainings = trainingRepository.GetAllTrainings();

            List<TrainingPeriod> trainingPeriods = trainingPeriodRepository.GetAllTrainingPeriods().ToList();

            // Uklanjanje zauzetih termina s popisa dostupnih termina
            foreach (TrainingGroup group in trainingGroupRepository.GetAllTrainingGroups())
            {
                if (group.Name != groupName)
                {
                    foreach (TrainingPeriod trainingPeriod in group.TrainingPeriods)
                    {
                        int index = trainingPeriods.FindIndex(period => period.PeriodId == trainingPeriod.PeriodId);

                        if (index != -1)
                        {
                            trainingPeriods.RemoveAt(index);
                        }
                    }
                }
            }

            List<TrainingPeriod> newPeriods = trainingPeriods.Select(item => item).ToList();

            form.ShowModal(mainController, trainingGroup, trainings, newPeriods);
        }

        public void AddTrainingGroup(TrainingGroup trainingGroup, ITrainingGroupRepository trainingGroupRepository)
        {
            try
            {
                trainingGroupRepository.AddTrainingGroup(trainingGroup);
            }
            catch (NameAlreadyTakenException nameEx)
            {
                throw nameEx;
            }
        }

        public void EditTrainingGroupWithName(string groupName, TrainingGroup trainingGroup, ITrainingGroupRepository trainingGroupRepository)
        {
            try
            {
                trainingGroupRepository.EditTrainingGroupWithName(groupName, trainingGroup);
            }
            catch (NameAlreadyTakenException nameEx)
            {
                throw nameEx;
            }
        }

        public void RemoveTrainingGroupWithName(string groupName, ITrainingGroupRepository trainingGroupRepository, IClientRepository clientRepository)
        {
            if (clientRepository.GetAllClientsFromTrainingGroup(groupName).Count == 0)
            {
                trainingGroupRepository.RemoveTrainingGroupWithName(groupName);
            }
            else
            {
                throw new DependantDataNotDeletableException();
            }
        }
    }
}