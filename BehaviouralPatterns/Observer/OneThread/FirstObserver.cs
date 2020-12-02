using System;
using System.Collections.Generic;
using System.Text;
using Observer.OneThread;

namespace Observer.OneThread
{
    internal class FirstObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            ((Subject) subject).NumField += 1;
            Console.WriteLine($"OneObserver: Reacted to the event. {((Subject)subject).NumField}");
        }
    }
}
