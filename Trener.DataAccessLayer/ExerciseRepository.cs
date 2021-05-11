using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trener.BaseLib;
using Trener.Model;
using Trener.Model.Repositories;

namespace Trener.DataAccessLayer
{
    public class ExerciseRepository : Subject, IExerciseRepository
    {
        private static ExerciseRepository instance = null;
        private List<Exercise> exercises = new List<Exercise>();

        public ExerciseRepository()
        {
        }

        public static ExerciseRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new ExerciseRepository();
            }

            return instance;
        }

        public List<Exercise> GetAllExercises()
        {
            return exercises;
        }

        public Exercise GetExerciseWithName(string exerciseName)
        {
            if (ExistsExerciseWithName(exerciseName))
            {
                return exercises.Find(exercise => exercise.Name == exerciseName);
            }
            else
            {
                throw new NonexistantNameException();
            }
        }

        public void AddExercise(Exercise exercise)
        {
            if (!ExistsExerciseWithName(exercise.Name))
            {
                exercises.Add(exercise);

                SendDataToObservers();
            }
            else
            {
                throw new NameAlreadyTakenException();
            }
        }

        public void EditExerciseWithName(string exerciseName, Exercise newExercise)
        {
            if (ExistsExerciseWithName(exerciseName))
            {
                if (exerciseName == newExercise.Name || !ExistsExerciseWithName(newExercise.Name))
                {
                    int exerciseToEditIndex = exercises.FindIndex(exercise => exercise.Name == exerciseName);
                    exercises[exerciseToEditIndex] = newExercise;

                    SendDataToObservers();
                }
                else
                {
                    throw new NameAlreadyTakenException();
                }
            }
            else
            {
                throw new NonexistantNameException();
            }
        }

        public void RemoveExerciseWithName(string exerciseName)
        {
            if (ExistsExerciseWithName(exerciseName))
            {
                Exercise exerciseToRemove = exercises.Find(exercise => exercise.Name == exerciseName);
                exercises.Remove(exerciseToRemove);

                SendDataToObservers();
            }
            else
            {
                throw new NonexistantNameException();
            }
        }

        public bool ExistsExerciseWithName(string exerciseName)
        {
            return exercises.Any(exercise => exercise.Name == exerciseName);
        }

        private void SendDataToObservers()
        {
            Dictionary<string, List<object>> newData = new Dictionary<string, List<object>>();
            List<object> exercisesObj = exercises.Cast<object>().ToList();
            newData["exercises"] = exercisesObj;
            NotifyObservers(newData);
        }
    }
}