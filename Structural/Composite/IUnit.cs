namespace DesignPatterns.Structural.Composite
{
    public interface IUnit
    {
        int GetStrength();
        void AddUnit(IUnit unit);
    }
}
