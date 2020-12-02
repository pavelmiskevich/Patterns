using System;
using System.Collections.Generic;
using Command.Commands;
using Command.SomeClasses;

namespace Command
{
    //https://refactoring.guru/ru/design-patterns/command/csharp/example
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: переделать с лямбда выражениями
            Invoker invoker = new Invoker();
            invoker.AddCommand(new SecondSomeClassCommand(new SecondSomeClass(), "commandOne"));
            invoker.AddCommand(new FirstSomeClassCommand(new FirstSomeClass(), "commandTwo"));
            invoker.DoWork();
            Console.WriteLine("Press Ctrl + Z");
            invoker.CtrlZ();
            invoker.DoWork();
            Console.WriteLine("Many command");
            List<ICommand> commands = new List<ICommand>
            {
                new FirstSomeClassCommand(new FirstSomeClass(), "commandThree"),
                new SecondSomeClassCommand(new SecondSomeClass(), "commandFour"),
                new FirstSomeClassCommand(new FirstSomeClass(), "commandFive")
            };

            invoker.AddCommand(new ManyCommand(commands));
            invoker.DoWork();
            Console.WriteLine("Press Ctrl + Z");
            invoker.CtrlZ();
            invoker.DoWork();
            Console.WriteLine("Press Ctrl + Z");
            invoker.CtrlZ();
            invoker.DoWork();

            Console.ReadKey();
        }
    }
}
