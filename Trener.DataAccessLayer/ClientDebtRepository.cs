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
    public class ClientDebtRepository : Subject, IClientDebtRepository
    {
        private static ClientDebtRepository instance = null;
        private static int nextId = 1;
        private List<ClientDebt> clientDebts = new List<ClientDebt>();

        public ClientDebtRepository()
        {
        }

        public static ClientDebtRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new ClientDebtRepository();
            }

            return instance;
        }

        private int GetNextId()
        {
            int id = nextId;
            nextId++;

            return id;
        }

        public List<ClientDebt> GetAllClientDebts()
        {
            return clientDebts;
        }

        public List<ClientDebt> GetAllDebtsOfClientWithOib(string oib)
        {
            return clientDebts.FindAll(debt => debt.ClientInDebt.Oib == oib);
        }

        public ClientDebt GetClientDebtWithId(int debtId)
        {
            if (ExistsClientDebtWithId(debtId))
            {
                return clientDebts.Find(debt => debt.DebtId == debtId);
            }
            else
            {
                throw new NonexistantIdException();
            }
        }

        public void AddClientDebt(ClientDebt clientDebt)
        {
            int debtId = GetNextId();
            clientDebt.DebtId = debtId;

            clientDebts.Add(clientDebt);

            SendDataToObservers();
        }

        public void EditClientDebtWithId(int debtId, ClientDebt newClientDebt)
        {
            if (ExistsClientDebtWithId(debtId))
            {
                newClientDebt.DebtId = debtId;
                int clientDebtToEditIndex = clientDebts.FindIndex(debt => debt.DebtId == debtId);
                clientDebts[clientDebtToEditIndex] = newClientDebt;

                SendDataToObservers();
            }
            else
            {
                throw new NonexistantIdException();
            }
        }

        public void RemoveClientDebtWithId(int debtId)
        {
            if (ExistsClientDebtWithId(debtId))
            {
                ClientDebt clientDebtToRemove = clientDebts.Find(debt => debt.DebtId == debtId);
                clientDebts.Remove(clientDebtToRemove);

                SendDataToObservers();
            }
            else
            {
                throw new NonexistantIdException();
            }
        }

        public bool ExistsClientDebtWithId(int debtId)
        {
            return clientDebts.Any(debt => debt.DebtId == debtId);
        }

        private void SendDataToObservers()
        {
            Dictionary<string, List<object>> newData = new Dictionary<string, List<object>>();
            List<object> clientDebtsObj = clientDebts.Cast<object>().ToList();
            newData["clientDebts"] = clientDebtsObj;
            NotifyObservers(newData);
        }
    }
}