using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.ManyThread
{
    internal interface IMTSubject
    {
        void Attach(IMTObserver observer);

        void Detach(IMTObserver observer);

        void Notify();
    }
}
