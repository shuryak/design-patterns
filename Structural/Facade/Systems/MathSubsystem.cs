namespace DesignPatterns.Structural.Facade.Systems
{
    public class MathSubsystem
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Product(int a, int b)
        {
            return a * b;
        }
    }
}
