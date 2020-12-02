using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class Invoker
    {
        //private Stack<ICommand> _stackCommands;
        private List<ICommand> _commands;
        //private ICommand _lastCommands;
        private Stack<ICommand> _stackLastCommands;

        public Invoker()
        {
            //_stackCommands = new Stack<ICommand>();
            _commands = new List<ICommand>();
            _stackLastCommands = new Stack<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            //_stackCommands.Push(command);
            //_lastCommands = command;
            _commands.Add(command);
            _stackLastCommands.Push(command);
        }

        public void CtrlZ()
        {
            //_stackCommands.Pop();
            //_commands.Remove(_lastCommands);
            _commands.Remove(_stackLastCommands.Pop());
        }

        public void DoWork()
        {
            //foreach (var command in _stackCommands)
            //{
            //    command.Execute();
            //}

            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}
