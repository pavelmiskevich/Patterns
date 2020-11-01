using System;

namespace Decorator
{
    class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            //base.Operation();

            Console.WriteLine("ConcreteDecoratorA");
        }
    }
}
