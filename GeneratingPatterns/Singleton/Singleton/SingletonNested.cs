using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class SingletonNested
    {
        public static string text = "hello";

        public string Date { get; private set; }

        private SingletonNested()
        {
            Date = System.DateTime.Now.TimeOfDay.ToString();
        }

        public static SingletonNested getInstance()
        {
            return Nested.instance;
        }

        private class Nested
        {
            static Nested() { }
            internal static readonly SingletonNested instance = new SingletonNested();
        }
    }
}
