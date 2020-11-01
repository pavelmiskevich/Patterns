using System;

namespace State
{
    class Program
    {
        //https://ru.wikipedia.org/wiki/Состояние_(шаблон_проектирования)
        //https://metanit.com/sharp/patterns/3.6.php
        //https://refactoring.guru/ru/design-patterns/state
        //https://bool.dev/blog/detail/pattern-sostoyanie
        static void Main(string[] args)
        {
            var automat = new Automat(9);

            automat.GotApplication();
            automat.CheckApplication();
            automat.RentApartment();

            Console.ReadKey();
        }
    }
}
