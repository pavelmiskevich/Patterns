using System;
using System.Collections.Generic;
using System.Text;
using Observer.OneThread;

namespace Observer.ManyThread
{
    internal class MTFirstObserver : IMTObserver
    {
        public void Update(IMTSubject subject)
        {
            ((MTSubject) subject).NumField += 1;
            Console.WriteLine($"OneObserver: Reacted to the event. {((MTSubject)subject).NumField}");
        }
    }
}
