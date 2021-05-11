using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trener.Model
{
    public class TrainingGroup
    {
        public string Name { get; set; }
        public Training Training { get; set; }
        public List<TrainingPeriod> TrainingPeriods { get; set; }
        public decimal MonthlyPrice { get; set; }

        public TrainingGroup(string name, Training training, List<TrainingPeriod> trainingPeriods, decimal monthlyPrice)
        {
            if (!string.IsNullOrEmpty(name) && training != null
                && trainingPeriods.Count > 0 && monthlyPrice > 0)
            {
                Name = name;
                Training = training;
                TrainingPeriods = trainingPeriods;
                MonthlyPrice = monthlyPrice;
            }
            else
            {
                throw new IncompleteDataException();
            }
        }
    }
}