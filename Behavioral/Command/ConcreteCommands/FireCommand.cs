namespace DesignPatterns.Behavioral.Command.ConcreteCommands
{
    public class FireCommand : Command
    {
        public FireCommand(Game game) : base(game)
        {
        }
        
        public override void Execute()
        {
            Game.Fire();
        }
    }
}
