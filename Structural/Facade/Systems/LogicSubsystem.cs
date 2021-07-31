namespace DesignPatterns.Structural.Facade.Systems
{
    public class LogicSubsystem
    {
        public bool IsGreater(int a, int b)
        {
            return a > b;
        }

        public bool IsLess(int a, int b)
        {
            return a < b;
        }
    }
}
