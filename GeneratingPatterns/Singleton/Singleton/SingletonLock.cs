using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class SingletonLock
    {
        private static SingletonLock instance;
        private static object syncRoot = new Object();

        public string Date { get; private set; }

        private SingletonLock()
        {
            Date = System.DateTime.Now.TimeOfDay.ToString();
        }

        public static SingletonLock getInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new SingletonLock();
                }
            }
            return instance;
        }
    }
}
