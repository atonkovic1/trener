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
    public class ClientController
    {
        public void ShowClients(IViewClientsForm form, IClientRepository clientRepository, IMainController mainController)
        {
            List<Client> clients = clientRepository.GetAllClients();

            Subject subject = (Subject)clientRepository;
            subject.Attach((IObserver)form);

            form.ShowModaless(mainController, clients);
        }

        public void ShowAddClient(IFormFactory formFactory,
                                    ITrainingGroupRepository trainingGroupRepository,
                                    IMainController mainController)
        {
            IAddClientForm form = formFactory.CreateAddClientForm();

            List<TrainingGroup> trainingGroups = trainingGroupRepository.GetAllTrainingGroups();

            form.ShowModal(mainController, trainingGroups);
        }

        public void ShowEditClient(IFormFactory formFactory,
                                        IClientRepository clientRepository,
                                        ITrainingGroupRepository trainingGroupRepository,
                                        string oib,
                                        IMainController mainController)
        {
            IEditClientForm form = formFactory.CreateEditClientForm();

            Client client = clientRepository.GetClientWithOib(oib);

            List<TrainingGroup> trainingGroups = trainingGroupRepository.GetAllTrainingGroups();

            form.ShowModal(mainController, client, trainingGroups);
        }

        public void AddClient(Client client, IClientRepository clientRepository)
        {
            try
            {
                clientRepository.AddClient(client);
            }
            catch (OibAlreadyTakenException oibEx)
            {
                throw oibEx;
            }
        }

        public void EditClientWithOib(string oib, Client client, IClientRepository clientRepository)
        {
            clientRepository.EditClientWithOib(oib, client);
        }

        public void RemoveClientWithOib(string oib, IClientRepository clientRepository, IClientDebtRepository clientDebtRepository)
        {
            if (clientDebtRepository.GetAllDebtsOfClientWithOib(oib).Count == 0)
            {
                clientRepository.RemoveClientWithOib(oib);
            }
            else
            {
                throw new DependantDataNotDeletableException();
            }
        }
    }
}