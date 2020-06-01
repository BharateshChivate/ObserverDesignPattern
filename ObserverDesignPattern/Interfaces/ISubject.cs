using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Interfaces
{
    interface ISubject
    {
        void Register(IObserver observer);
        void Deregister(IObserver observer);

        void NotifyObservers(string availability);

        void SetAvailability(string availability);

        void GetAvailability();
    }
}
