namespace DesignPatterns.Behavioral.Command
{
    public class Joystick
    {
        private readonly CommandSequenceAnalyzer _analyzer;
        
        private readonly Command _squareCommand;
        private readonly Command _triangleCommand;
        private readonly Command _circleCommand;
        private readonly Command _crossCommand;
        
        private readonly Command _cheatCodeCommand;

        public Joystick(
            CommandSequenceAnalyzer analyzer,
            Command squareCommand,
            Command triangleCommand,
            Command circleCommand,
            Command crossCommand,
            Command cheatCodeCommand
            )
        {
            _analyzer = analyzer;
            _squareCommand = squareCommand;
            _triangleCommand = triangleCommand;
            _circleCommand = circleCommand;
            _crossCommand = crossCommand;
            _cheatCodeCommand = cheatCodeCommand;
        }

        public void PressSquareButton()
        {
            ExecuteCommand(_squareCommand);
        }

        public void PressTriangleButton()
        {
            ExecuteCommand(_triangleCommand);
        }

        public void PressCircleButton()
        {
            ExecuteCommand(_circleCommand);
        }

        public void PressCrossButton()
        {
            ExecuteCommand(_crossCommand);
        }

        private void ExecuteCommand(Command command)
        {
            _analyzer.AddCommand(command);

            command.Execute();
            
            if (_analyzer.CheckForSpecialSequence())
            {
                _cheatCodeCommand.Execute();
            }
        }
    }
}
