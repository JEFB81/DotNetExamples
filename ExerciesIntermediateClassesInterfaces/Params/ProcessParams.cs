using System;

namespace ExerciesIntermediateClassesInterfaces.Params
{
    public class ProcessParams
    {
        // use of calculator class
        public void UseParams()
        {
            var calculator = new Calculator();
            // sent multiple values
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
        }
    }
}
