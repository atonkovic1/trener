using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trener.Model;

namespace Trener.BaseLib
{
    public interface IViewClientDebtsForm
    {
        void ShowModaless(IMainController mainController, List<ClientDebt> clientDebts);
    }
}