using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.ManyThread
{
    internal interface IMTObserver
    {
        void Update(IMTSubject subject);
    }
}
