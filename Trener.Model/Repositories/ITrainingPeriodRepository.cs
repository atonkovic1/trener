using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trener.Model.Repositories
{
    public interface ITrainingPeriodRepository
    {
        List<TrainingPeriod> GetAllTrainingPeriods();

        List<TrainingPeriod> GetAllTrainingPeriodsOnDayOfWeek(DayOfWeek dayOfWeek);

        TrainingPeriod GetTrainingPeriodWithId(int periodId);

        void AddTrainingPeriod(TrainingPeriod trainingPeriod);

        void EditTrainingPeriodWithId(int periodId, TrainingPeriod newTrainingPeriod);

        void RemoveTrainingPeriodWithId(int periodId);

        bool ExistsTrainingPeriodWithId(int periodId);
    }
}