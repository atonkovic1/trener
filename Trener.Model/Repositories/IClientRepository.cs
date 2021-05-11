using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trener.Model.Repositories
{
    public interface IClientRepository
    {
        List<Client> GetAllClients();

        List<Client> GetAllClientsFromTrainingGroup(string trainingGroupName);

        Client GetClientWithOib(string oib);

        void AddClient(Client client);

        void EditClientWithOib(string oib, Client newClient);

        void RemoveClientWithOib(string oib);

        bool ExistsClientWithOib(string oib);
    }
}