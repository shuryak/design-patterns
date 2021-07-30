namespace DesignPatterns.Structural.Composite.Units
{
    public class Archer : IUnit
    {
        public int GetStrength()
        {
            return 1;
        }

        public void AddUnit(IUnit unit)
        {
            throw new CannotAddToLeafException();
        }
    }
}
