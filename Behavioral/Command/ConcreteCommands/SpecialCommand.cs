namespace DesignPatterns.Behavioral.Command.ConcreteCommands
{
    public class SpecialCommand : Command
    {
        public SpecialCommand(Game game) : base(game)
        {
        }
        
        public override void Execute()
        {
            Game.ThrowGrenade();
        }
    }
}
