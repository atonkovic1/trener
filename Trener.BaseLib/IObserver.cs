using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trener.BaseLib
{
    public interface IObserver
    {
        void UpdateForm(Dictionary<string, List<object>> newData);

        string GetName();
    }
}