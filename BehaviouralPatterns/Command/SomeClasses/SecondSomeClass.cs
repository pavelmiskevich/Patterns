using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Command.SomeClasses
{
    internal class SecondSomeClass
    {
        public void ThreeMove()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod().DeclaringType.Name} {MethodBase.GetCurrentMethod().Name} ");
        }

        public void FourdMove()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod().DeclaringType.Name} {MethodBase.GetCurrentMethod().Name} ");
        }
    }
}
