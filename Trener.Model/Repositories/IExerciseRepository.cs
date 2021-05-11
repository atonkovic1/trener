using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trener.Model.Repositories
{
    public interface IExerciseRepository
    {
        List<Exercise> GetAllExercises();

        Exercise GetExerciseWithName(string exerciseName);

        void AddExercise(Exercise exercise);

        void EditExerciseWithName(string exerciseName, Exercise newExercise);

        void RemoveExerciseWithName(string exerciseName);

        bool ExistsExerciseWithName(string exerciseName);
    }
}