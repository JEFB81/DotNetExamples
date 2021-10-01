using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesIntermediateClassesInterfaces.Params
{
    public class Calculator
    {
        // it is possible to receive multiple values through the parameter numbers
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }

            return sum;
        }
    }
}
