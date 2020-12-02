using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Command.SomeClasses;

namespace Command.Commands
{
    internal class ManyCommand : ICommand
    {
        private readonly List<ICommand> _commands;

        public ManyCommand(List<ICommand> commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            Console.WriteLine($"{MethodBase.GetCurrentMethod().DeclaringType.Name} {MethodBase.GetCurrentMethod().Name} {_commands.Count}");
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}
