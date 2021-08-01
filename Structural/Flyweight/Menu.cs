using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Flyweight
{
    // Flyweight pool/cache class (Flyweight factory)
    public class Menu
    {
        private readonly List<Tuple<string, CoffeeFlavor>> _flavors = new List<Tuple<string, CoffeeFlavor>>();

        public int TotalCoffeeFlavorsMade => _flavors.Count;
        
        public CoffeeFlavor Lookup(string flavorName)
        {
            if (_flavors.All(t => t.Item1 != flavorName))
                _flavors.Add(new Tuple<string, CoffeeFlavor>(flavorName, new CoffeeFlavor(flavorName)));

            return _flavors.Find(t => t.Item1 == flavorName)?.Item2;
        }
    }
}
