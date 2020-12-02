using Builder.Builder;
using System;

namespace Builder
{
    //https://refactoring.guru/ru/design-patterns/builder/csharp/example
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard basic product:");
            director.buildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.buildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Custom product:");
            builder.JustDoItOne();
            builder.JustDoItThree();
            Console.Write(builder.GetProduct().ListParts());
        }
    }
}
