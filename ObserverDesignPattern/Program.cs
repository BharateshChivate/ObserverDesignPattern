using ObserverDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // publisher
            ISubject mobile = new Subject("RedMi", 10000, "Out of Stock");

            mobile.GetAvailability();

            // subscribers
            IObserver user1 = new Observer("Ram", mobile);
            IObserver user2 = new Observer("Raju", mobile);
            IObserver user3 = new Observer("Rakesh", mobile);

            mobile.Register(user1);
            mobile.Register(user2);
            mobile.Register(user3);

            // status of publisher changed
            mobile.SetAvailability("Available");
            Console.ReadLine();
        }
    }
}
