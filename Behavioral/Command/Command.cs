namespace DesignPatterns.Behavioral.Command
{
    public abstract class Command
    {
        protected readonly Game Game;

        protected Command(Game game)
        {
            Game = game;
        }
        
        public abstract void Execute();
    }
}
