using ObserverDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class Observer : IObserver
    {
        public Observer(string name, ISubject sub)
        {
            this.Name = name;
            sub.Register(this);
        }
        public string Name { get; set; }
        public void Update(string available)
        {
            Console.WriteLine("Product is " + available);
        }
    }
}
