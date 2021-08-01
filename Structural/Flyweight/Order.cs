using System;

namespace DesignPatterns.Structural.Flyweight
{
    public class Order
    {
        private readonly int _tableNumber;
        private readonly CoffeeFlavor _flavor;

        public Order(int tableNumber, CoffeeFlavor flavor)
        {
            _tableNumber = tableNumber;
            _flavor = flavor;
        }

        public void Serve()
        {
            Console.WriteLine($"Serving {_flavor} to table {_tableNumber}");
        }
    }
}
