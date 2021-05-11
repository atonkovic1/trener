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
    public class TrainingRepository : Subject, ITrainingRepository
    {
        private static TrainingRepository instance = null;
        private List<Training> trainings = new List<Training>();

        public TrainingRepository()
        {
        }

        public static TrainingRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new TrainingRepository();
            }

            return instance;
        }

        public List<Training> GetAllTrainings()
        {
            return trainings;
        }

        public Training GetTrainingWithName(string trainingName)
        {
            if (ExistsTrainingWithName(trainingName))
            {
                return trainings.Find(training => training.Name == trainingName);
            }
            else
            {
                throw new NonexistantNameException();
            }
        }

        public void AddTraining(Training training)
        {
            if (!ExistsTrainingWithName(training.Name))
            {
                trainings.Add(training);

                SendDataToObservers();
            }
            else
            {
                throw new NameAlreadyTakenException();
            }
        }

        public void EditTrainingWithName(string trainingName, Training newTraining)
        {
            if (ExistsTrainingWithName(trainingName))
            {
                if (trainingName == newTraining.Name || !ExistsTrainingWithName(newTraining.Name))
                {
                    int trainingToEditIndex = trainings.FindIndex(training => training.Name == trainingName);
                    trainings[trainingToEditIndex] = newTraining;

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

        public void RemoveTrainingWithName(string trainingName)
        {
            if (ExistsTrainingWithName(trainingName))
            {
                Training trainingToRemove = trainings.Find(training => training.Name == trainingName);
                trainings.Remove(trainingToRemove);

                SendDataToObservers();
            }
            else
            {
                throw new NonexistantNameException();
            }
        }

        public bool ExistsTrainingWithName(string trainingName)
        {
            return trainings.Any(training => training.Name == trainingName);
        }

        private void SendDataToObservers()
        {
            Dictionary<string, List<object>> newData = new Dictionary<string, List<object>>();
            List<object> trainingsObj = trainings.Cast<object>().ToList();
            newData["trainings"] = trainingsObj;
            NotifyObservers(newData);
        }
    }
}