using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    internal class FastHorse : IHorse
    {
        public void Move()
        {
            Console.WriteLine("I riding");
        }

        public void Eating()
        {
            Console.WriteLine("I eating");
        }
    }
}
