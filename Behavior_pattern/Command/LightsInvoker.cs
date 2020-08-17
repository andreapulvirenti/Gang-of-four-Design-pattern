using System;
using System.Collections.Generic;
namespace Command
{
    public class LightsInvoker
    {
        public List<ICommand> _lightCommands = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            this._lightCommands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var cmd in _lightCommands)
            {
                cmd.Execute();
            }
        }

        public void RemoveCommand(ICommand command)
        {
            this._lightCommands.Remove(command);
        }

        public void ResetCommands()
        {
            this._lightCommands = new List<ICommand>();
        }

    }
}