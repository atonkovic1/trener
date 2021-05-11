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
    public class TrainingPeriodRepository : Subject, ITrainingPeriodRepository
    {
        private static TrainingPeriodRepository instance = null;
        private static int nextId = 1;
        private List<TrainingPeriod> trainingPeriods = new List<TrainingPeriod>();

        public TrainingPeriodRepository()
        {
        }

        public static TrainingPeriodRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new TrainingPeriodRepository();
            }

            return instance;
        }

        private int GetNextId()
        {
            int id = nextId;
            nextId++;

            return id;
        }

        public List<TrainingPeriod> GetAllTrainingPeriods()
        {
            return trainingPeriods;
        }

        public List<TrainingPeriod> GetAllTrainingPeriodsOnDayOfWeek(DayOfWeek dayOfWeek)
        {
            return trainingPeriods.FindAll(trainingPeriod => trainingPeriod.DayOfWeek == dayOfWeek);
        }

        public TrainingPeriod GetTrainingPeriodWithId(int trainingPeriodId)
        {
            if (ExistsTrainingPeriodWithId(trainingPeriodId))
            {
                return trainingPeriods.Find(trainingPeriod => trainingPeriod.PeriodId == trainingPeriodId);
            }
            else
            {
                throw new NonexistantIdException();
            }
        }

        public void AddTrainingPeriod(TrainingPeriod trainingPeriod)
        {
            if (!trainingPeriods.Any(period => period.DayOfWeek == trainingPeriod.DayOfWeek
                && trainingPeriod.PeriodEnd > period.PeriodStart
                && trainingPeriod.PeriodStart < period.PeriodEnd))
            {
                int periodId = GetNextId();
                trainingPeriod.PeriodId = periodId;

                trainingPeriods.Add(trainingPeriod);

                SendDataToObservers();
            }
            else
            {
                throw new PeriodAlreadyTakenException();
            }
        }

        public void EditTrainingPeriodWithId(int periodId, TrainingPeriod newTrainingPeriod)
        {
            if (ExistsTrainingPeriodWithId(periodId))
            {
                if (!trainingPeriods.Any(period => period.PeriodId != periodId
                    && period.DayOfWeek == newTrainingPeriod.DayOfWeek
                    && newTrainingPeriod.PeriodEnd > period.PeriodStart
                    && newTrainingPeriod.PeriodStart < period.PeriodEnd))
                {
                    newTrainingPeriod.PeriodId = periodId;
                    int trainingPeriodToEditIndex = trainingPeriods.FindIndex(trainingPeriod => trainingPeriod.PeriodId == periodId);
                    trainingPeriods[trainingPeriodToEditIndex] = newTrainingPeriod;

                    SendDataToObservers();
                }
                else
                {
                    throw new PeriodAlreadyTakenException();
                }
            }
            else
            {
                throw new NonexistantIdException();
            }
        }

        public void RemoveTrainingPeriodWithId(int periodId)
        {
            if (ExistsTrainingPeriodWithId(periodId))
            {
                TrainingPeriod trainingPeriodToRemove = trainingPeriods.Find(trainingPeriod => trainingPeriod.PeriodId == periodId);
                trainingPeriods.Remove(trainingPeriodToRemove);

                SendDataToObservers();
            }
            else
            {
                throw new NonexistantIdException();
            }
        }

        public bool ExistsTrainingPeriodWithId(int periodId)
        {
            return trainingPeriods.Any(trainingPeriod => trainingPeriod.PeriodId == periodId);
        }

        private void SendDataToObservers()
        {
            Dictionary<string, List<object>> newData = new Dictionary<string, List<object>>();
            List<object> trainingPeriodsObj = trainingPeriods.Cast<object>().ToList();
            newData["trainingPeriods"] = trainingPeriodsObj;
            NotifyObservers(newData);
        }
    }
}