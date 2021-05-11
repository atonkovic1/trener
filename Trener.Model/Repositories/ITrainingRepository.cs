using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trener.Model.Repositories
{
    public interface ITrainingRepository
    {
        List<Training> GetAllTrainings();

        Training GetTrainingWithName(string trainingName);

        void AddTraining(Training training);

        void EditTrainingWithName(string trainingName, Training newTraining);

        void RemoveTrainingWithName(string trainingName);

        bool ExistsTrainingWithName(string trainingName);
    }
}