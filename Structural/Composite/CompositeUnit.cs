using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Structural.Composite.Units;

namespace DesignPatterns.Structural.Composite
{
    public class CompositeUnit : IUnit
    {
        private readonly List<IUnit> _units = new List<IUnit>();

        public int GetStrength()
        {
            return _units.Sum(unit => unit.GetStrength());
        }

        public void AddUnit(IUnit unit)
        {
            _units.Add(unit);
        }
    }
}
