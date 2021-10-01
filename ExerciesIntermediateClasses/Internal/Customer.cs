using System;

namespace ExerciesIntermediateClasses.Internal
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            // this is not a good practive because it create tight coupling
            // do this beter by interface
            var rateCalculator = new RateCalculator();

            if (rateCalculator.CalculateRating(this) == 0)
                Console.WriteLine("Promoted to level 1");
            else
                Console.WriteLine("Promoted to level 2");

        }

        public void PromoteUsingInternal()
        {
            var calculator = new RateCalculatorInternal();
            if (calculator.Calculate() == 1)
                Console.WriteLine("Promoted to level 1");
            else
                Console.WriteLine("Promoted to level 2");
        }
    }
}
