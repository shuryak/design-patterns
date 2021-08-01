namespace DesignPatterns.Structural.Flyweight
{
    // Flyweight
    public class CoffeeFlavor
    {
        private readonly string _name;

        public CoffeeFlavor(string newFlavor)
        {
            _name = newFlavor;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
