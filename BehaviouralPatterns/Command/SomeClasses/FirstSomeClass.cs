using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Command.SomeClasses
{
    internal class FirstSomeClass
    {
        public void FirstMove()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod().DeclaringType.Name} {MethodBase.GetCurrentMethod().Name} ");
        }

        public void SecondMove()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod().DeclaringType.Name} {MethodBase.GetCurrentMethod().Name} ");
        }
    }
}
