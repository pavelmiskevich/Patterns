using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.OneThread
{
    internal class SecondObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            ((Subject)subject).NumField += 1;
            Console.WriteLine($"TwoObserver: Reacted to the event. {((Subject)subject).NumField}");
        }
    }
}
