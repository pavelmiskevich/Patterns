using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class SingletonROLazy
    {
        private static readonly Lazy<SingletonROLazy> lazy = new Lazy<SingletonROLazy>(() => new SingletonROLazy());

        public string Date { get; private set; }

        private SingletonROLazy()
        {
            Date = System.DateTime.Now.TimeOfDay.ToString();
        }

        public static SingletonROLazy getInstance()
        {
            return lazy.Value;
        }
    }
}
