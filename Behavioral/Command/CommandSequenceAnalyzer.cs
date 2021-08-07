using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Behavioral.Command.ConcreteCommands;

namespace DesignPatterns.Behavioral.Command
{
    public class CommandSequenceAnalyzer
    {
        private readonly List<Command> _commandList = new List<Command>();
        
        public void AddCommand(Command command)
        {
            _commandList.Add(command);
        }

        public bool CheckForSpecialSequence()
        {
            List<Command> sequence = _commandList.TakeLast(3).ToList();

            return sequence.Count >= 3 &&
                   sequence[0] is ActionCommand &&
                   sequence[1] is SpecialCommand &&
                   sequence[2] is JumpCommand;
        }
    }
}
