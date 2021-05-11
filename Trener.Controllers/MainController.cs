using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trener.BaseLib;
using Trener.Model;
using Trener.Model.Repositories;

namespace Trener.Controllers
{
    public class MainController : IMainController
    {
        private IFormFactory formFactory = null;

        private IClientDebtRepository clientDebtRepository = null;
        private IClientRepository clientRepository = null;
        private IExerciseRepository exerciseRepository = null;
        private ITrainingGroupRepository trainingGroupRepository = null;
        private ITrainingPeriodRepository trainingPeriodRepository = null;
        private ITrainingRepository trainingRepository = null;

        private bool isDefaultModelLoaded = false;

        public MainController(IFormFactory formFactory, IClientDebtRepository clientDebtRepository,
            IClientRepository clientRepository, IExerciseRepository exerciseRepository,
            ITrainingGroupRepository trainingGroupRepository, ITrainingPeriodRepository trainingPeriodRepository,
            ITrainingRepository trainingRepository)
        {
            this.formFactory = formFactory;
            this.clientDebtRepository = clientDebtRepository;
            this.clientRepository = clientRepository;
            this.exerciseRepository = exerciseRepository;
            this.trainingGroupRepository = trainingGroupRepository;
            this.trainingPeriodRepository = trainingPeriodRepository;
            this.trainingRepository = trainingRepository;
        }

        public void LoadDefaultModel()
        {
            if (isDefaultModelLoaded == false)
            {
                try
                {
                    Exercise exercise1 = new Exercise("Čučnjevi", FitnessLevel.Beginner, "Opis čučnjeva");
                    Exercise exercise2 = new Exercise("Sklekovi", FitnessLevel.Intermediate, "Opis sklekova");
                    Exercise exercise3 = new Exercise("Plank", FitnessLevel.Beginner, "Opis planka");
                    Exercise exercise4 = new Exercise("Ruski čučnjevi", FitnessLevel.Advanced, "Opis ruskih čučnjeva");
                    Exercise exercise5 = new Exercise("Bočni plank", FitnessLevel.Intermediate, "Opis bočnog planka");
                    Exercise exercise6 = new Exercise("Podizanja trupa", FitnessLevel.Intermediate, "Opis podizanja trupa");

                    exerciseRepository.AddExercise(exercise1);
                    exerciseRepository.AddExercise(exercise2);
                    exerciseRepository.AddExercise(exercise3);
                    exerciseRepository.AddExercise(exercise4);
                    exerciseRepository.AddExercise(exercise5);
                    exerciseRepository.AddExercise(exercise6);

                    Training training1 = new Training("Trening funkcionalne snage", FitnessLevel.Beginner,
                                                        new List<Exercise> { exercise1, exercise2, exercise3 });
                    Training training2 = new Training("Napredni trening funkcionalne snage", FitnessLevel.Advanced,
                                    new List<Exercise> { exercise1, exercise2, exercise3, exercise4, exercise5, exercise6 });

                    trainingRepository.AddTraining(training1);
                    trainingRepository.AddTraining(training2);

                    TrainingPeriod trainingPeriod1 = new TrainingPeriod(DayOfWeek.Monday, new TimeSpan(17, 0, 0),
                                                                        new TimeSpan(18, 0, 0));
                    TrainingPeriod trainingPeriod2 = new TrainingPeriod(DayOfWeek.Tuesday, new TimeSpan(17, 0, 0),
                                                                        new TimeSpan(18, 0, 0));
                    TrainingPeriod trainingPeriod3 = new TrainingPeriod(DayOfWeek.Wednesday, new TimeSpan(17, 0, 0),
                                                                        new TimeSpan(18, 0, 0));
                    TrainingPeriod trainingPeriod4 = new TrainingPeriod(DayOfWeek.Thursday, new TimeSpan(17, 0, 0),
                                                                        new TimeSpan(18, 0, 0));
                    TrainingPeriod trainingPeriod5 = new TrainingPeriod(DayOfWeek.Friday, new TimeSpan(17, 0, 0),
                                                                        new TimeSpan(18, 0, 0));
                    TrainingPeriod trainingPeriod6 = new TrainingPeriod(DayOfWeek.Saturday, new TimeSpan(17, 0, 0),
                                                                        new TimeSpan(18, 0, 0));
                    TrainingPeriod trainingPeriod7 = new TrainingPeriod(DayOfWeek.Sunday, new TimeSpan(17, 0, 0),
                                                                        new TimeSpan(18, 0, 0));

                    trainingPeriodRepository.AddTrainingPeriod(trainingPeriod1);
                    trainingPeriodRepository.AddTrainingPeriod(trainingPeriod2);
                    trainingPeriodRepository.AddTrainingPeriod(trainingPeriod3);
                    trainingPeriodRepository.AddTrainingPeriod(trainingPeriod4);
                    trainingPeriodRepository.AddTrainingPeriod(trainingPeriod5);
                    trainingPeriodRepository.AddTrainingPeriod(trainingPeriod6);
                    trainingPeriodRepository.AddTrainingPeriod(trainingPeriod7);

                    TrainingGroup trainingGroup1 = new TrainingGroup("Početnička grupa", training1,
                                        new List<TrainingPeriod> { trainingPeriod2, trainingPeriod4 }, 200.00M);
                    TrainingGroup trainingGroup2 = new TrainingGroup("Napredna grupa", training2,
                        new List<TrainingPeriod> { trainingPeriod1, trainingPeriod3, trainingPeriod5 }, 300.00M);

                    trainingGroupRepository.AddTrainingGroup(trainingGroup1);
                    trainingGroupRepository.AddTrainingGroup(trainingGroup2);

                    Client client1 = new Client("12938549201", "Ivana", "Marković", new DateTime(1981, 1, 8), "0912728274",
                                                new DateTime(2020, 2, 10), FitnessLevel.Beginner, "Ima problema s koljenima",
                                                new List<TrainingGroup> { trainingGroup1 });
                    Client client2 = new Client("52932999221", "Đorđe", "Ivanović", new DateTime(1991, 5, 20), "0981827364",
                                                new DateTime(2020, 9, 5), FitnessLevel.Advanced, "",
                                                new List<TrainingGroup> { trainingGroup1, trainingGroup2 });
                    Client client3 = new Client("29375948378", "Josip", "Cvitković", new DateTime(1995, 10, 15), "0913819204",
                                                new DateTime(2020, 10, 10), FitnessLevel.Advanced, "",
                                                new List<TrainingGroup> { trainingGroup2 });
                    Client client4 = new Client("10382960594", "Sara", "Praputak", new DateTime(1998, 4, 25), "0998278477",
                                                new DateTime(2021, 1, 11), FitnessLevel.Beginner, "Ima problema s leđima",
                                                new List<TrainingGroup> { trainingGroup1 });
                    Client client5 = new Client("10283953829", "Ivona", "Malenica", new DateTime(1997, 12, 12), "0919287782",
                                                new DateTime(2021, 1, 15), FitnessLevel.Beginner, "",
                                                new List<TrainingGroup> { trainingGroup1 });

                    clientRepository.AddClient(client1);
                    clientRepository.AddClient(client2);
                    clientRepository.AddClient(client3);
                    clientRepository.AddClient(client4);
                    clientRepository.AddClient(client5);

                    ClientDebt clientDebt1 = new ClientDebt(client1, 200.00M, "Članarina za studeni 2020 (Početna grupa)");
                    ClientDebt clientDebt2 = new ClientDebt(client1, 200.00M, "Članarina za prosinac 2020 (Početna grupa)");
                    ClientDebt clientDebt3 = new ClientDebt(client2, 200.00M, "Članarina za prosinac 2020 (Početna grupa)");
                    ClientDebt clientDebt4 = new ClientDebt(client2, 300.00M, "Članarina za prosinac 2020 (Napredna grupa)");
                    ClientDebt clientDebt5 = new ClientDebt(client3, 300.00M, "Članarina za prosinac 2020 (Napredna grupa)");
                    ClientDebt clientDebt6 = new ClientDebt(client4, 200.00M, "Članarina za prosinac 2020 (Početna grupa)");
                    ClientDebt clientDebt7 = new ClientDebt(client5, 200.00M, "Članarina za prosinac 2020 (Početna grupa)");

                    clientDebtRepository.AddClientDebt(clientDebt1);
                    clientDebtRepository.AddClientDebt(clientDebt2);
                    clientDebtRepository.AddClientDebt(clientDebt3);
                    clientDebtRepository.AddClientDebt(clientDebt4);
                    clientDebtRepository.AddClientDebt(clientDebt5);
                    clientDebtRepository.AddClientDebt(clientDebt6);
                    clientDebtRepository.AddClientDebt(clientDebt7);

                    isDefaultModelLoaded = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void DeleteObserver(IObserver observer)
        {
            Subject subject = (Subject)clientDebtRepository;
            subject.Delete(observer);

            subject = (Subject)clientRepository;
            subject.Delete(observer);

            subject = (Subject)exerciseRepository;
            subject.Delete(observer);

            subject = (Subject)trainingGroupRepository;
            subject.Delete(observer);

            subject = (Subject)trainingPeriodRepository;
            subject.Delete(observer);

            subject = (Subject)trainingRepository;
            subject.Delete(observer);
        }

        public void ShowClients()
        {
            ClientController clientController = new ClientController();

            IViewClientsForm form = formFactory.CreateViewClientsForm();

            clientController.ShowClients(form, clientRepository, this);
        }

        public void ShowAddClient()
        {
            ClientController clientController = new ClientController();

            clientController.ShowAddClient(formFactory, trainingGroupRepository, this);
        }

        public void ShowEditClient(string oib)
        {
            ClientController clientController = new ClientController();

            clientController.ShowEditClient(formFactory, clientRepository, trainingGroupRepository, oib, this);
        }

        public void AddClient(Client client)
        {
            ClientController clientController = new ClientController();

            clientController.AddClient(client, clientRepository);
        }

        public void EditClientWithOib(string oib, Client client)
        {
            ClientController clientController = new ClientController();

            clientController.EditClientWithOib(oib, client, clientRepository);
        }

        public void RemoveClientWithOib(string oib)
        {
            ClientController clientController = new ClientController();

            clientController.RemoveClientWithOib(oib, clientRepository, clientDebtRepository);
        }

        public void ShowClientDebts()
        {
            ClientDebtController clientDebtController = new ClientDebtController();

            IViewClientDebtsForm form = formFactory.CreateViewClientDebtsForm();

            clientDebtController.ShowClientDebts(form, clientDebtRepository, this);
        }

        public void ShowAddClientDebt()
        {
            ClientDebtController clientDebtController = new ClientDebtController();

            clientDebtController.ShowAddClientDebt(formFactory, clientRepository, this);
        }

        public void ShowEditClientDebt(int debtId)
        {
            ClientDebtController clientDebtController = new ClientDebtController();

            clientDebtController.ShowEditClientDebt(formFactory, clientDebtRepository, debtId, this);
        }

        public void AddClientDebt(ClientDebt clientDebt)
        {
            ClientDebtController clientDebtController = new ClientDebtController();

            clientDebtController.AddClientDebt(clientDebt, clientDebtRepository);
        }

        public void EditClientDebtWithId(int debtId, ClientDebt clientDebt)
        {
            ClientDebtController clientDebtController = new ClientDebtController();

            clientDebtController.EditClientDebtWithId(debtId, clientDebt, clientDebtRepository);
        }

        public void RemoveClientDebtWithId(int debtId)
        {
            ClientDebtController clientDebtController = new ClientDebtController();

            clientDebtController.RemoveClientDebtWithId(debtId, clientDebtRepository);
        }

        public void ShowTrainingGroups()
        {
            TrainingGroupController trainingGroupController = new TrainingGroupController();

            IViewTrainingGroupsForm form = formFactory.CreateViewTrainingGroupsForm();

            trainingGroupController.ShowTrainingGroups(form, trainingGroupRepository, this);
        }

        public void ShowAddTrainingGroup()
        {
            TrainingGroupController trainingGroupController = new TrainingGroupController();

            trainingGroupController.ShowAddTrainingGroup(formFactory, trainingGroupRepository, trainingRepository, trainingPeriodRepository, this);
        }

        public void ShowEditTrainingGroup(string groupName)
        {
            TrainingGroupController trainingGroupController = new TrainingGroupController();

            trainingGroupController.ShowEditTrainingGroup(formFactory, trainingGroupRepository,
                trainingRepository, trainingPeriodRepository, groupName, this);
        }

        public void AddTrainingGroup(TrainingGroup trainingGroup)
        {
            TrainingGroupController trainingGroupController = new TrainingGroupController();

            trainingGroupController.AddTrainingGroup(trainingGroup, trainingGroupRepository);
        }

        public void EditTrainingGroupWithName(string groupName, TrainingGroup trainingGroup)
        {
            TrainingGroupController trainingGroupController = new TrainingGroupController();

            trainingGroupController.EditTrainingGroupWithName(groupName, trainingGroup, trainingGroupRepository);
        }

        public void RemoveTrainingGroupWithName(string groupName)
        {
            TrainingGroupController trainingGroupController = new TrainingGroupController();

            trainingGroupController.RemoveTrainingGroupWithName(groupName, trainingGroupRepository, clientRepository);
        }

        public void ShowTrainingPeriods()
        {
            TrainingPeriodController trainingPeriodController = new TrainingPeriodController();

            IViewTrainingPeriodsForm form = formFactory.CreateViewTrainingPeriodsForm();

            trainingPeriodController.ShowTrainingPeriods(form, trainingPeriodRepository, this);
        }

        public void ShowAddTrainingPeriod()
        {
            TrainingPeriodController trainingPeriodController = new TrainingPeriodController();

            trainingPeriodController.ShowAddTrainingPeriod(formFactory, this);
        }

        public void ShowEditTrainingPeriod(int periodId)
        {
            TrainingPeriodController trainingPeriodController = new TrainingPeriodController();

            trainingPeriodController.ShowEditTrainingPeriod(formFactory, trainingPeriodRepository, periodId, this);
        }

        public void AddTrainingPeriod(TrainingPeriod trainingPeriod)
        {
            TrainingPeriodController trainingPeriodController = new TrainingPeriodController();

            trainingPeriodController.AddTrainingPeriod(trainingPeriod, trainingPeriodRepository);
        }

        public void EditTrainingPeriodWithId(int periodId, TrainingPeriod trainingPeriod)
        {
            TrainingPeriodController trainingPeriodController = new TrainingPeriodController();

            trainingPeriodController.EditTrainingPeriodWithId(periodId, trainingPeriod, trainingPeriodRepository);
        }

        public void RemoveTrainingPeriodWithId(int periodId)
        {
            TrainingPeriodController trainingPeriodController = new TrainingPeriodController();

            trainingPeriodController.RemoveTrainingPeriodWithId(periodId, trainingPeriodRepository, trainingGroupRepository);
        }

        public void ShowTrainings()
        {
            TrainingController trainingController = new TrainingController();

            IViewTrainingsForm form = formFactory.CreateViewTrainingsForm();

            trainingController.ShowTrainings(form, trainingRepository, this);
        }

        public void ShowAddTraining()
        {
            TrainingController trainingController = new TrainingController();

            trainingController.ShowAddTraining(formFactory, exerciseRepository, this);
        }

        public void ShowEditTraining(string trainingName)
        {
            TrainingController trainingController = new TrainingController();

            trainingController.ShowEditTraining(formFactory, trainingRepository, exerciseRepository, trainingName, this);
        }

        public void AddTraining(Training training)
        {
            TrainingController trainingController = new TrainingController();

            trainingController.AddTraining(training, trainingRepository);
        }

        public void EditTrainingWithName(string trainingName, Training training)
        {
            TrainingController trainingController = new TrainingController();

            trainingController.EditTrainingWithName(trainingName, training, trainingRepository);
        }

        public void RemoveTrainingWithName(string trainingName)
        {
            TrainingController trainingController = new TrainingController();

            trainingController.RemoveTrainingWithName(trainingName, trainingRepository, trainingGroupRepository);
        }

        public void ShowExercises()
        {
            ExerciseController exerciseController = new ExerciseController();

            IViewExercisesForm form = formFactory.CreateViewExercisesForm();

            exerciseController.ShowExercises(form, exerciseRepository, this);
        }

        public void ShowAddExercise()
        {
            ExerciseController exerciseController = new ExerciseController();

            exerciseController.ShowAddExercise(formFactory, this);
        }

        public void ShowEditExercise(string exerciseName)
        {
            ExerciseController exerciseController = new ExerciseController();

            exerciseController.ShowEditExercise(formFactory, exerciseRepository, exerciseName, this);
        }

        public void AddExercise(Exercise exercise)
        {
            ExerciseController exerciseController = new ExerciseController();

            exerciseController.AddExercise(exercise, exerciseRepository);
        }

        public void EditExerciseWithName(string exerciseName, Exercise exercise)
        {
            ExerciseController exerciseController = new ExerciseController();

            exerciseController.EditExerciseWithName(exerciseName, exercise, exerciseRepository);
        }

        public void RemoveExerciseWithName(string exerciseName)
        {
            ExerciseController exerciseController = new ExerciseController();

            exerciseController.RemoveExerciseWithName(exerciseName, exerciseRepository, trainingRepository);
        }
    }
}