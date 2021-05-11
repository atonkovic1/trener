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
    public class ClientRepository : Subject, IClientRepository
    {
        private static ClientRepository instance = null;
        private List<Client> clients = new List<Client>();

        public ClientRepository()
        {
        }

        public static ClientRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new ClientRepository();
            }

            return instance;
        }

        public List<Client> GetAllClients()
        {
            return clients;
        }

        public List<Client> GetAllClientsFromTrainingGroup(string trainingGroupName)
        {
            return clients.FindAll(client => client.InTrainingGroups.Any(group => group.Name == trainingGroupName));
        }

        public Client GetClientWithOib(string oib)
        {
            if (ExistsClientWithOib(oib))
            {
                return clients.Find(client => client.Oib == oib);
            }
            else
            {
                throw new NonexistantOibException();
            }
        }

        public void AddClient(Client client)
        {
            if (!ExistsClientWithOib(client.Oib))
            {
                clients.Add(client);

                SendDataToObservers();
            }
            else
            {
                throw new OibAlreadyTakenException();
            }
        }

        public void EditClientWithOib(string oib, Client newClient)
        {
            if (ExistsClientWithOib(oib))
            {
                newClient.Oib = oib;
                int clientToEditIndex = clients.FindIndex(client => client.Oib == oib);
                clients[clientToEditIndex] = newClient;

                SendDataToObservers();
            }
            else
            {
                throw new NonexistantOibException();
            }
        }

        public void RemoveClientWithOib(string oib)
        {
            if (ExistsClientWithOib(oib))
            {
                Client clientToRemove = clients.Find(client => client.Oib == oib);
                clients.Remove(clientToRemove);

                SendDataToObservers();
            }
            else
            {
                throw new NonexistantOibException();
            }
        }

        public bool ExistsClientWithOib(string oib)
        {
            return clients.Any(client => client.Oib == oib);
        }

        private void SendDataToObservers()
        {
            Dictionary<string, List<object>> newData = new Dictionary<string, List<object>>();
            List<object> clientsObj = clients.Cast<object>().ToList();
            newData["clients"] = clientsObj;
            NotifyObservers(newData);
        }
    }
}