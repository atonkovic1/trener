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
    public class ExerciseController
    {
        public void ShowExercises(IViewExercisesForm form, IExerciseRepository exerciseRepository,
                                    IMainController mainController)
        {
            List<Exercise> exercises = exerciseRepository.GetAllExercises();

            Subject subject = (Subject)exerciseRepository;
            subject.Attach((IObserver)form);

            form.ShowModaless(mainController, exercises);
        }

        public void ShowAddExercise(IFormFactory formFactory,
                                    IMainController mainController)
        {
            IAddExerciseForm form = formFactory.CreateAddExerciseForm();

            form.ShowModal(mainController);
        }

        public void ShowEditExercise(IFormFactory formFactory,
                                        IExerciseRepository exerciseRepository,
                                        string exerciseName,
                                        IMainController mainController)
        {
            IEditExerciseForm form = formFactory.CreateEditExerciseForm();

            Exercise exercise = exerciseRepository.GetExerciseWithName(exerciseName);

            form.ShowModal(mainController, exercise);
        }

        public void AddExercise(Exercise exercise, IExerciseRepository exerciseRepository)
        {
            try
            {
                exerciseRepository.AddExercise(exercise);
            }
            catch (NameAlreadyTakenException nameEx)
            {
                throw nameEx;
            }
        }

        public void EditExerciseWithName(string exerciseName, Exercise exercise, IExerciseRepository exerciseRepository)
        {
            try
            {
                exerciseRepository.EditExerciseWithName(exerciseName, exercise);
            }
            catch (NameAlreadyTakenException nameEx)
            {
                throw nameEx;
            }
        }

        public void RemoveExerciseWithName(string exerciseName, IExerciseRepository exerciseRepository, ITrainingRepository trainingRepository)
        {
            List<Training> trainings = trainingRepository.GetAllTrainings();

            if (!trainings.Any(training =>
                training.Exercises.FindIndex(exercise =>
                    exercise.Name == exerciseName) != -1))
            {
                exerciseRepository.RemoveExerciseWithName(exerciseName);
            }
            else
            {
                throw new DependantDataNotDeletableException();
            }
        }
    }
}