using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trener.Model
{
    public class ClientDebt
    {
        public int DebtId { get; set; }
        public Client ClientInDebt { get; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        public ClientDebt(Client clientInDebt, decimal amount, string description)
        {
            if (clientInDebt != null && amount > 0)
            {
                DebtId = -1;
                ClientInDebt = clientInDebt;
                Amount = amount;
                Description = description;
            }
            else
            {
                throw new IncompleteDataException();
            }
        }
    }
}