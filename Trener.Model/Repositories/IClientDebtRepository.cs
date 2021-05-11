using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trener.Model.Repositories
{
    public interface IClientDebtRepository
    {
        List<ClientDebt> GetAllClientDebts();

        List<ClientDebt> GetAllDebtsOfClientWithOib(string oib);

        ClientDebt GetClientDebtWithId(int debtId);

        void AddClientDebt(ClientDebt clientDebt);

        void EditClientDebtWithId(int debtId, ClientDebt newClientDebt);

        void RemoveClientDebtWithId(int debtId);

        bool ExistsClientDebtWithId(int debtId);
    }
}