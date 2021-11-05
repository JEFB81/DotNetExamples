using System;
using System.Collections.Generic;

namespace DecoratorPattern
{
    /// <summary>
    /// The 'ConcreteDecoratorB Renewable' class
    /// </summary>
    public class Reorder : Decorator
    {
        protected readonly List<string> orders = new();

        // Constructor
        public Reorder(LibraryItem libraryItem)
            : base(libraryItem)
        { }

        public void OrderItem(string name)
        {
            orders.Add(name);
            libraryItem.NumCopies++;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("\nReorder ------ ");

            foreach (string item in orders)
            {
                Console.WriteLine(" Order: " + item);
            }
        }
    }
}
