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
    public class TrainingGroupRepository : Subject, ITrainingGroupRepository
    {
        private static TrainingGroupRepository instance = null;
        private List<TrainingGroup> trainingGroups = new List<TrainingGroup>();

        public TrainingGroupRepository()
        {
        }

        public static TrainingGroupRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new TrainingGroupRepository();
            }

            return instance;
        }

        public List<TrainingGroup> GetAllTrainingGroups()
        {
            return trainingGroups;
        }

        public TrainingGroup GetTrainingGroupWithName(string trainingGroupName)
        {
            if (ExistsTrainingGroupWithName(trainingGroupName))
            {
                return trainingGroups.Find(trainingGroup => trainingGroup.Name == trainingGroupName);
            }
            else
            {
                throw new NonexistantNameException();
            }
        }

        public void AddTrainingGroup(TrainingGroup trainingGroup)
        {
            bool IsValidTrainingGroup = true;

            foreach (TrainingPeriod trainingPeriod in trainingGroup.TrainingPeriods)
            {
                foreach (TrainingGroup group in trainingGroups)
                {
                    if (group.TrainingPeriods.Any(period =>
                        period.DayOfWeek == trainingPeriod.DayOfWeek
                        && trainingPeriod.PeriodEnd > period.PeriodStart
                        && trainingPeriod.PeriodStart < period.PeriodEnd))
                    {
                        IsValidTrainingGroup = false;
                        break;
                    }
                }

                if (!IsValidTrainingGroup)
                {
                    break;
                }
            }

            if (IsValidTrainingGroup)
            {
                if (!ExistsTrainingGroupWithName(trainingGroup.Name))
                {
                    trainingGroups.Add(trainingGroup);

                    SendDataToObservers();
                }
                else
                {
                    throw new NameAlreadyTakenException();
                }
            }
            else
            {
                throw new PeriodAlreadyTakenException();
            }
        }

        public void EditTrainingGroupWithName(string trainingGroupName, TrainingGroup newTrainingGroup)
        {
            if (ExistsTrainingGroupWithName(trainingGroupName))
            {
                if (trainingGroupName == newTrainingGroup.Name || !ExistsTrainingGroupWithName(newTrainingGroup.Name))
                {
                    bool IsValidTrainingGroup = true;

                    foreach (TrainingPeriod trainingPeriod in newTrainingGroup.TrainingPeriods)
                    {
                        List<TrainingGroup> otherGroups = trainingGroups.FindAll(item =>
                            item.Name != newTrainingGroup.Name);

                        foreach (TrainingGroup group in otherGroups)
                        {
                            if (group.TrainingPeriods.Any(period =>
                                period.DayOfWeek == trainingPeriod.DayOfWeek
                                && trainingPeriod.PeriodEnd > period.PeriodStart
                                && trainingPeriod.PeriodStart < period.PeriodEnd))
                            {
                                IsValidTrainingGroup = false;
                                break;
                            }
                        }

                        if (!IsValidTrainingGroup)
                        {
                            break;
                        }
                    }

                    if (IsValidTrainingGroup)
                    {
                        int trainingGroupToEditIndex = trainingGroups.FindIndex(trainingGroup => trainingGroup.Name == trainingGroupName);
                        trainingGroups[trainingGroupToEditIndex] = newTrainingGroup;

                        SendDataToObservers();
                    }
                    else
                    {
                        throw new PeriodAlreadyTakenException();
                    }
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

        public void RemoveTrainingGroupWithName(string trainingGroupName)
        {
            if (ExistsTrainingGroupWithName(trainingGroupName))
            {
                TrainingGroup trainingGroupToRemove = trainingGroups.Find(trainingGroup => trainingGroup.Name == trainingGroupName);
                trainingGroups.Remove(trainingGroupToRemove);

                SendDataToObservers();
            }
            else
            {
                throw new NonexistantNameException();
            }
        }

        public bool ExistsTrainingGroupWithName(string trainingGroupName)
        {
            return trainingGroups.Any(trainingGroup => trainingGroup.Name == trainingGroupName);
        }

        private void SendDataToObservers()
        {
            Dictionary<string, List<object>> newData = new Dictionary<string, List<object>>();
            List<object> trainingGroupsObj = trainingGroups.Cast<object>().ToList();
            newData["trainingGroups"] = trainingGroupsObj;
            NotifyObservers(newData);
        }
    }
}