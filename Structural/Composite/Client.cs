using System;
using DesignPatterns.Structural.Composite.Units;

namespace DesignPatterns.Structural.Composite
{
    /*
     * Pattern Composite composes an object into a tree-like structure and allows work with the it as if it was a
     * singular object
     *
     * Adds a hierarchy: part / whole
     */
    public class Client
    {
        public void Main()
        {
            CompositeUnit army = new CompositeUnit();

            for (int i = 0; i< 4; i++)
                army.AddUnit(CreateLegion());

            Console.WriteLine("Army strength is " + army.GetStrength());
        }

        private static IUnit CreateLegion()
        {
            CompositeUnit legion = new CompositeUnit();
            
            for (int i = 0; i < 3000; i++)
                legion.AddUnit(new Infantryman());
            for (int i = 0; i < 1200; i++)
                legion.AddUnit(new Archer());
            for (int i = 0; i < 300; i++)
                legion.AddUnit(new Horseman());

            return legion;
        }
    }
}
