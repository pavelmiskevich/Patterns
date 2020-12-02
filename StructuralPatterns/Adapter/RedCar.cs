using System;

namespace Adapter
{
    internal class RedCar : ICar
    {
        public void Move()
        {
            Console.WriteLine("I driving");
        }

        public void Refueling()
        {
            Console.WriteLine("I refueling");
        }
    }
}
