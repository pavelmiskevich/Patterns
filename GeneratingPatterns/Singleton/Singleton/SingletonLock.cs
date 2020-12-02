using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class SingletonLock
    {
        private static SingletonLock _instance;
        private static object syncRoot = new object();

        public string Date { get; private set; }

        private SingletonLock()
        {
            Date = System.DateTime.Now.TimeOfDay.ToString();
        }

        public static SingletonLock getInstance()
        {
            if (_instance == null)
            {
                lock (syncRoot)
                {
                    if (_instance == null)
                        _instance = new SingletonLock();
                }
            }
            return _instance;
        }
    }
}
