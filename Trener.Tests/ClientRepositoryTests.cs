using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection;
using Trener.DataAccessLayer;
using Trener.Model;

namespace Trener.Tests
{
    [TestClass]
    public class ClientRepositoryTests
    {
        private static ExerciseRepository exerciseRepository = ExerciseRepository.GetInstance();
        private static TrainingRepository trainingRepository = TrainingRepository.GetInstance();
        private static TrainingPeriodRepository trainingPeriodRepository = TrainingPeriodRepository.GetInstance();
        private static TrainingGroupRepository trainingGroupRepository = TrainingGroupRepository.GetInstance();
        private static ClientRepository clientRepository = ClientRepository.GetInstance();
        private static ClientDebtRepository clientDebtRepository = ClientDebtRepository.GetInstance();

        [ClassInitialize]
        public static void UpdateRepositories(TestContext context)
        {
            // Ako repozitoriji nisu napunjeni
            if (clientDebtRepository.GetAllClientDebts().Count == 0)
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
            }
        }

        [TestMethod]
        public void Test_AddClient()
        {
            TrainingGroup group = trainingGroupRepository.GetTrainingGroupWithName("Početnička grupa");

            int numClientsBefore = clientRepository.GetAllClients().Count;

            Client client = new Client("52938549299", "Ivanka", "Bošković", new DateTime(1981, 2, 8), "0912258674",
                                        new DateTime(2020, 2, 20), FitnessLevel.Beginner, "",
                                        new List<TrainingGroup> { group });

            clientRepository.AddClient(client);

            int numClientsAfter = clientRepository.GetAllClients().Count;

            List<Client> clients = clientRepository.GetAllClients();

            Assert.AreEqual(numClientsAfter, numClientsBefore + 1);
            Assert.IsTrue(clients.Contains(client));

            clientRepository.RemoveClientWithOib("52938549299");
        }

        [TestMethod]
        [ExpectedException(typeof(OibAlreadyTakenException))]
        public void Test_AddClientWithAlreadyExistingOib()
        {
            TrainingGroup group = trainingGroupRepository.GetTrainingGroupWithName("Početnička grupa");

            Client client1 = new Client("52938549299", "Ivanka", "Bošković", new DateTime(1981, 2, 8), "0912258674",
                                        new DateTime(2020, 2, 20), FitnessLevel.Beginner, "",
                                        new List<TrainingGroup> { group });
            Client client2 = new Client("52938549299", "Ivanko", "Bošković", new DateTime(1981, 3, 8), "0992258674",
                                        new DateTime(2020, 3, 20), FitnessLevel.Beginner, "",
                                        new List<TrainingGroup> { group });

            clientRepository.AddClient(client1);
            clientRepository.AddClient(client2);
        }

        [TestMethod]
        [ExpectedException(typeof(NonexistantOibException))]
        public void Test_GetClientWithNonexistantOib()
        {
            clientRepository.GetClientWithOib("test");
        }
    }
}