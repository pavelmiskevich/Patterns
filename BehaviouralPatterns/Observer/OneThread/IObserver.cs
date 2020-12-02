using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.OneThread
{
    internal interface IObserver
    {
        void Update(ISubject subject);
    }
}
