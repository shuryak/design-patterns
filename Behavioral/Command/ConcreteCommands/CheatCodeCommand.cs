namespace DesignPatterns.Behavioral.Command.ConcreteCommands
{
    public class CheatCodeCommand : Command
    {
        public CheatCodeCommand(Game game) : base(game)
        {
        }

        public override void Execute()
        {
            Game.CheatAction();
        }
    }
}
