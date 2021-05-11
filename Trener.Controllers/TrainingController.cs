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
    public class TrainingController
    {
        public void ShowTrainings(IViewTrainingsForm form, ITrainingRepository trainingRepository,
                                    IMainController mainController)
        {
            List<Training> trainings = trainingRepository.GetAllTrainings();

            Subject subject = (Subject)trainingRepository;
            subject.Attach((IObserver)form);

            form.ShowModaless(mainController, trainings);
        }

        public void ShowAddTraining(IFormFactory formFactory, IExerciseRepository exerciseRepository,
                                        IMainController mainController)
        {
            IAddTrainingForm form = formFactory.CreateAddTrainingForm();

            List<Exercise> exercises = exerciseRepository.GetAllExercises();

            form.ShowModal(mainController, exercises);
        }

        public void ShowEditTraining(IFormFactory formFactory,
                                        ITrainingRepository trainingRepository,
                                        IExerciseRepository exerciseRepository,
                                        string trainingName,
                                        IMainController mainController)
        {
            IEditTrainingForm form = formFactory.CreateEditTrainingForm();

            Training training = trainingRepository.GetTrainingWithName(trainingName);

            List<Exercise> exercises = exerciseRepository.GetAllExercises();

            form.ShowModal(mainController, training, exercises);
        }

        public void AddTraining(Training training, ITrainingRepository trainingRepository)
        {
            try
            {
                trainingRepository.AddTraining(training);
            }
            catch (NameAlreadyTakenException nameEx)
            {
                throw nameEx;
            }
        }

        public void EditTrainingWithName(string trainingName, Training training, ITrainingRepository trainingRepository)
        {
            try
            {
                trainingRepository.EditTrainingWithName(trainingName, training);
            }
            catch (NameAlreadyTakenException nameEx)
            {
                throw nameEx;
            }
        }

        public void RemoveTrainingWithName(string trainingName, ITrainingRepository trainingRepository, ITrainingGroupRepository trainingGroupRepository)
        {
            List<TrainingGroup> trainingGroups = trainingGroupRepository.GetAllTrainingGroups();

            if (!trainingGroups.Any(group =>
                group.Training.Name == trainingName))
            {
                trainingRepository.RemoveTrainingWithName(trainingName);
            }
            else
            {
                throw new DependantDataNotDeletableException();
            }
        }
    }
}