using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.ManyThread
{
    internal class MTSecondObserver : IMTObserver
    {
        public void Update(IMTSubject subject)
        {
            ((MTSubject)subject).NumField += 1;
            Console.WriteLine($"TwoObserver: Reacted to the event. {((MTSubject)subject).NumField}");
        }
    }
}
