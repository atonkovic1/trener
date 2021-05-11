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
    public class ClientDebtController
    {
        public void ShowClientDebts(IViewClientDebtsForm form, IClientDebtRepository clientDebtRepository,
                                    IMainController mainController)
        {
            List<ClientDebt> clientDebts = clientDebtRepository.GetAllClientDebts();

            Subject subject = (Subject)clientDebtRepository;
            subject.Attach((IObserver)form);

            form.ShowModaless(mainController, clientDebts);
        }

        public void ShowAddClientDebt(IFormFactory formFactory, IClientRepository clientRepository,
                                        IMainController mainController)
        {
            IAddClientDebtForm form = formFactory.CreateAddClientDebtForm();

            List<Client> clients = clientRepository.GetAllClients();

            form.ShowModal(mainController, clients);
        }

        public void ShowEditClientDebt(IFormFactory formFactory,
                                        IClientDebtRepository clientDebtRepository,
                                        int debtId,
                                        IMainController mainController)
        {
            IEditClientDebtForm form = formFactory.CreateEditClientDebtForm();

            ClientDebt clientDebt = clientDebtRepository.GetClientDebtWithId(debtId);

            form.ShowModal(mainController, clientDebt);
        }

        public void AddClientDebt(ClientDebt clientDebt, IClientDebtRepository clientDebtRepository)
        {
            clientDebtRepository.AddClientDebt(clientDebt);
        }

        public void EditClientDebtWithId(int debtId, ClientDebt clientDebt, IClientDebtRepository clientDebtRepository)
        {
            clientDebtRepository.EditClientDebtWithId(debtId, clientDebt);
        }

        public void RemoveClientDebtWithId(int debtId, IClientDebtRepository clientDebtRepository)
        {
            clientDebtRepository.RemoveClientDebtWithId(debtId);
        }
    }
}