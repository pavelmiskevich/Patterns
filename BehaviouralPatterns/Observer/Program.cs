using System;
using System.Threading;
using Observer;
using Observer.OneThread;
using Observer.ManyThread;

namespace Observer
{
    //https://ru.wikipedia.org/wiki/%D0%9D%D0%B0%D0%B1%D0%BB%D1%8E%D0%B4%D0%B0%D1%82%D0%B5%D0%BB%D1%8C_(%D1%88%D0%B0%D0%B1%D0%BB%D0%BE%D0%BD_%D0%BF%D1%80%D0%BE%D0%B5%D0%BA%D1%82%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D1%8F)#C#
    //https://refactoring.guru/ru/design-patterns/observer/csharp/example
    class Program
    {
        static void Main(string[] args)
        {
            //OneThread();
            while (true)
            {
                ManyThread();
            }
        }

        private static void OneThread()
        {
            var subject = new Subject();
            var observerFirst = new FirstObserver();
            subject.Attach(observerFirst);

            subject.Notify();

            var observerSecond = new SecondObserver();
            subject.Attach(observerSecond);
            subject.Attach(observerSecond);

            subject.Notify();

            subject.Detach(observerSecond);

            subject.Notify();
        }

        private static void ManyThread()
        {
            var subject = new MTSubject();
            var observerFirst = new MTFirstObserver();
            new Thread(() =>
            {
                subject.Attach(observerFirst);
            }).Start();

            new Thread(() =>
            {
                subject.Notify();
            }).Start();

            var observerSecond = new MTSecondObserver();
            new Thread(() =>
            {
                subject.Attach(observerSecond);
            }).Start();

            //subject.Notify();

            //subject.Detach(observerTwo);
            new Thread(() =>
            {
                subject.Detach(observerSecond);
            }).Start();

            subject.Notify();
        }
    }
}
