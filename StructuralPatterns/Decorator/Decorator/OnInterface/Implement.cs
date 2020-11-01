using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.OnInterface
{
    internal class Implement : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Implement");
        }
    }
}
