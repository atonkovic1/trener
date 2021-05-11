using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trener.Model;

namespace Trener.BaseLib
{
    public interface IAddTrainingForm
    {
        void ShowModal(IMainController mainController, List<Exercise> exercises);
    }
}