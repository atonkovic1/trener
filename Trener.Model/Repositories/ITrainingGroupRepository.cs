using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trener.Model.Repositories
{
    public interface ITrainingGroupRepository
    {
        List<TrainingGroup> GetAllTrainingGroups();

        TrainingGroup GetTrainingGroupWithName(string trainingGroupName);

        void AddTrainingGroup(TrainingGroup trainingGroup);

        void EditTrainingGroupWithName(string trainingGroupName, TrainingGroup newTrainingGroup);

        void RemoveTrainingGroupWithName(string trainingGroupName);

        bool ExistsTrainingGroupWithName(string trainingGroupName);
    }
}