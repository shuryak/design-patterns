using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Flyweight
{
    /*
     * Flyweight is an object that minimizes memory usage by sharing as much data as possible with other similar
     * objects
     *
     * Simple repeated representation would use an unacceptable amount of memory
     */
    public class Client
    {
        private readonly List<Order> _orders = new List<Order>(); // Context (unique, intrinsic states)
        private readonly Menu _menu = new Menu(); // Non-unique, extrinsic states

        private void TakeOrder(string flavorName, int table)
        {
            CoffeeFlavor flavor = _menu.Lookup(flavorName);
            Order order = new Order(table, flavor);
            _orders.Add(order);
        }

        private void Service()
        {
            foreach (Order order in _orders)
                order.Serve();
        }

        private string Report()
        {
            return "Total CoffeeFlavor objects made: " + _menu.TotalCoffeeFlavorsMade;
        }
        
        public void Main()
        {
            TakeOrder("Espresso", 1);
            TakeOrder("Cappuccino", 2);
            TakeOrder("Americano", 5);
            TakeOrder("Cappuccino", 8);
            TakeOrder("Cappuccino", 9);
            TakeOrder("Espresso", 10);

            Service();
            Console.WriteLine(Report());
        }
    }
}
