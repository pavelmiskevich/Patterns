using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class SingletonRO
    {
        private static readonly SingletonRO instance = new SingletonRO();

        public string Date { get; private set; }

        private SingletonRO()
        {
            Date = System.DateTime.Now.TimeOfDay.ToString();
        }

        public static SingletonRO getInstance()
        {
            return instance;
        }
    }
}
