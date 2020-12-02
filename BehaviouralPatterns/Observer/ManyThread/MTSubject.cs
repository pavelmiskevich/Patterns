using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.ManyThread
{
    internal class MTSubject : IMTSubject
    {
        public int NumField { get; set; }  = 2;
        private List<IMTObserver> _observers = new List<IMTObserver>();

        public void Attach(IMTObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IMTObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");
            //https://habr.com/ru/post/240385/
            //TODO: доделать потокобезопасный вызов
            ////решение раз
            //for (int i = _observers.Count - 1; i >= 0; i--)
            //{
            //    _observers[i].Update(this);
            //}
            //решение два
            foreach (var observer in _observers.ToList())
            {
                observer.Update(this);
            }
            //однопоточный вариант
            //foreach (var observer in _observers)
            //{
            //    observer.Update(this);
            //}
        }
    }
}
