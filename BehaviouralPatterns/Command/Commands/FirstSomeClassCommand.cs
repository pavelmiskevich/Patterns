using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Command.SomeClasses;

namespace Command.Commands
{
    internal class FirstSomeClassCommand : ICommand
    {
        private readonly FirstSomeClass _firstSomeClass;
        private readonly string _nameOfCommand;

        public FirstSomeClassCommand(FirstSomeClass firstSomeClass, string nameOfCommand)
        {
            _firstSomeClass = firstSomeClass;
            _nameOfCommand = nameOfCommand;
        }

        public void Execute()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod().DeclaringType.Name} {MethodBase.GetCurrentMethod().Name} {_nameOfCommand}");
            _firstSomeClass.FirstMove();
            _firstSomeClass.SecondMove();
        }
    }
}
