using ObserverDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class Subject : ISubject
    {

        public string  ProductName { get; set; }

        public int ProductPrice { get; set; }

        public string  Availability { get; set; }

        public Subject(string name, int price, string availability)
        {
            ProductName = name;
            ProductPrice = price;
            Availability = availability;
        }

        List<IObserver> observers = new List<IObserver>();
        public void Deregister(IObserver observer)
        {
            observers.Remove(observer);
        }

        // update subscribers abpout the change
        public void NotifyObservers(string availability)
        {
            foreach (var observer in observers)
            {
                observer.Update(availability);
            }
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        // subscribers should get notified about the status change in publisher
        public void SetAvailability(string availability)
        {
            Availability = availability;
            NotifyObservers(availability);
        }

        public void GetAvailability()
        {
            Console.WriteLine(Availability);
        }
    }
}
