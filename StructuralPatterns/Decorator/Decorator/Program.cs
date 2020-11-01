using Decorator.OnInterface;
using System;

namespace Decorator
{
    class Program
    {
        //https://ru.wikipedia.org/wiki/Декоратор_(шаблон_проектирования)
        //https://refactoring.guru/ru/design-patterns/decorator
        //https://metanit.com/sharp/patterns/4.1.php
        
        static void Main(string[] args)
        {
            // Create ConcreteComponent and two Decorators
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA dA = new ConcreteDecoratorA();
            ConcreteDecoratorB dB = new ConcreteDecoratorB();

            // Link decorators
            dA.SetComponent(c);
            dB.SetComponent(dA);

            dA.Operation();

            dB.Operation();

            //OnInterface
            Implement implement = new Implement();
            ConcreteDecoratorAI dAI = new ConcreteDecoratorAI();
            ConcreteDecoratorBI dBI = new ConcreteDecoratorBI();

            // Link decorators
            dAI.SetComponent(implement);
            dBI.SetComponent(dAI);

            implement.Operation();

            dAI.Operation();

            dBI.Operation();

            // Wait for user
            Console.Read();
        }
    }
}
