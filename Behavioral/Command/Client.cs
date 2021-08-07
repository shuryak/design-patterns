using DesignPatterns.Behavioral.Command.ConcreteCommands;

namespace DesignPatterns.Behavioral.Command
{
    /*
     * Pattern Command encapsulate a request as an object, thereby allowing for the parameterization of clients with 
     * different requests, and the queuing or logging of requests. It also allows for the support of undoable 
     * operations
     */
    public class Client
    {
        public void Main()
        {
            Game game = new Game();
            
            Joystick joystick = new Joystick(
                new CommandSequenceAnalyzer(),
                new FireCommand(game),
                new SpecialCommand(game),
                new ActionCommand(game),
                new JumpCommand(game),
                new CheatCodeCommand(game)
                );
            
            joystick.PressSquareButton();
            joystick.PressCircleButton();
            joystick.PressTriangleButton();
            joystick.PressCrossButton();
            joystick.PressSquareButton();
        }
    }
}
