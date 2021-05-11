using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trener.Model;

namespace Trener.BaseLib
{
    public interface IMainController
    {
        void DeleteObserver(IObserver observer);

        void ShowClients();

        void ShowAddClient();

        void ShowEditClient(string oib);

        void AddClient(Client client);

        void EditClientWithOib(string oib, Client client);

        void RemoveClientWithOib(string oib);

        void ShowClientDebts();

        void ShowAddClientDebt();

        void ShowEditClientDebt(int debtId);

        void AddClientDebt(ClientDebt clientDebt);

        void EditClientDebtWithId(int debtId, ClientDebt clientDebt);

        void RemoveClientDebtWithId(int debtId);

        void ShowTrainingGroups();

        void ShowAddTrainingGroup();

        void ShowEditTrainingGroup(string groupName);

        void AddTrainingGroup(TrainingGroup trainingGroup);

        void EditTrainingGroupWithName(string groupName, TrainingGroup trainingGroup);

        void RemoveTrainingGroupWithName(string groupName);

        void ShowTrainingPeriods();

        void ShowAddTrainingPeriod();

        void ShowEditTrainingPeriod(int periodId);

        void AddTrainingPeriod(TrainingPeriod trainingPeriod);

        void EditTrainingPeriodWithId(int periodId, TrainingPeriod trainingPeriod);

        void RemoveTrainingPeriodWithId(int periodId);

        void ShowTrainings();

        void ShowAddTraining();

        void ShowEditTraining(string trainingName);

        void AddTraining(Training training);

        void EditTrainingWithName(string trainingName, Training training);

        void RemoveTrainingWithName(string trainingName);

        void ShowExercises();

        void ShowAddExercise();

        void ShowEditExercise(string exerciseName);

        void AddExercise(Exercise exercise);

        void EditExerciseWithName(string exerciseName, Exercise exercise);

        void RemoveExerciseWithName(string exerciseName);
    }
}