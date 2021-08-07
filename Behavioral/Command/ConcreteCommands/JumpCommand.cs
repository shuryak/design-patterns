namespace DesignPatterns.Behavioral.Command.ConcreteCommands
{
    public class JumpCommand : Command
    {
        public JumpCommand(Game game) : base(game)
        {
        }
        
        public override void Execute()
        {
            Game.Jump();
        }
    }
}
