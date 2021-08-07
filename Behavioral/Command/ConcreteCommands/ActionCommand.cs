namespace DesignPatterns.Behavioral.Command.ConcreteCommands
{
    public class ActionCommand : Command
    {
        public ActionCommand(Game game) : base(game)
        {
        }
        
        public override void Execute()
        {
            Game.OpenDoor();
        }
    }
}
