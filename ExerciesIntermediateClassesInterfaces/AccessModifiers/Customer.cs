using System;

namespace ExerciesIntermediateClassesInterfaces.AccessModifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            if (CalculateRating(excludeOrders: true) == 0)
                Console.WriteLine("Promoted to level 1");
            else
                Console.WriteLine("Promoted to level 2");

        }

        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }

        // we have exposes out implementation by doing this, to our derived classes
        protected int CalculateRating()
        {
            return 2;
        }
    }
}
