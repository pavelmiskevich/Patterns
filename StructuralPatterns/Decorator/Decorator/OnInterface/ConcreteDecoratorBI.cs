using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.OnInterface
{
    class ConcreteDecoratorBI : DecoratorI
    {
        public override void Operation()
        {
            base.Operation();

            Console.WriteLine("ConcreteDecoratorBI");
        }
    }
}
