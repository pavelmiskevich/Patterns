using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Command.SomeClasses;

namespace Command.Commands
{
    internal class SecondSomeClassCommand : ICommand
    {
        private readonly SecondSomeClass _secondSomeClass;
        private readonly string _nameOfCommand;

        public SecondSomeClassCommand(SecondSomeClass secondSomeClass, string nameOfCommand)
        {
            _secondSomeClass = secondSomeClass;
            _nameOfCommand = nameOfCommand;
        }

        public void Execute()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod().DeclaringType.Name} {MethodBase.GetCurrentMethod().Name} {_nameOfCommand}");
            _secondSomeClass.FourdMove();
            _secondSomeClass.ThreeMove();
        }
    }
}
