using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trener.Model
{
    public class Training
    {
        public string Name { get; set; }
        public FitnessLevel RequiredFitnessLevel { get; set; }
        public List<Exercise> Exercises { get; set; }

        public Training(string name, FitnessLevel requiredFitnessLevel, List<Exercise> exercises)
        {
            if (!string.IsNullOrEmpty(name) && exercises.Count > 0)
            {
                Name = name;
                RequiredFitnessLevel = requiredFitnessLevel;
                Exercises = exercises;
            }
            else
            {
                throw new IncompleteDataException();
            }
        }
    }
}