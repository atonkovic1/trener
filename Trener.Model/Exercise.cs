using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trener.Model
{
    public class Exercise
    {
        public string Name { get; set; }
        public FitnessLevel RequiredFitnessLevel { get; set; }
        public string Description { get; set; }

        public Exercise(string name, FitnessLevel requiredFitnessLevel, string description)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Name = name;
                RequiredFitnessLevel = requiredFitnessLevel;
                Description = description;
            }
            else
            {
                throw new IncompleteDataException();
            }
        }
    }
}