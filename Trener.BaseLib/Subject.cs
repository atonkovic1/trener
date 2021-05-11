using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trener.BaseLib
{
    public abstract class Subject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            if (!IsAttached(observer))
            {
                observers.Add(observer);
            }
        }

        public void Delete(IObserver observer)
        {
            if (IsAttached(observer))
            {
                observers.Remove(observer);
            }
        }

        public bool IsAttached(IObserver observer)
        {
            return observers.Any(obs => obs.GetName() == observer.GetName());
        }

        public void NotifyObservers(Dictionary<string, List<object>> newData)
        {
            foreach (IObserver observer in observers.ToList())
            {
                observer.UpdateForm(newData);
            }
        }
    }
}