namespace DesignPatterns.Structural.Composite.Units
{
    public class Horseman : IUnit
    {
        public int GetStrength()
        {
            return 3;
        }

        public void AddUnit(IUnit unit)
        {
            throw new CannotAddToLeafException();
        }
    }
}
