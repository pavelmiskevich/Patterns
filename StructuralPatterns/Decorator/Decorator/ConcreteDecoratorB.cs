using System;

namespace Decorator
{
    class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();

            Console.WriteLine("ConcreteDecoratorB");
        }
    }
}
