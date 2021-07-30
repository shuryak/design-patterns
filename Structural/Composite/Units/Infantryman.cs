namespace DesignPatterns.Structural.Composite.Units
{
    public class Infantryman : IUnit
    {
        public int GetStrength()
        {
            return 2;
        }

        public void AddUnit(IUnit unit)
        {
            throw new CannotAddToLeafException();
        }
    }
}
