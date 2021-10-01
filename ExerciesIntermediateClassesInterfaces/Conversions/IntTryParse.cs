using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesIntermediateClassesInterfaces.Conversions
{
    public class IntTryParse
    {
        public  void Convert()
        {
            var result = int.TryParse("abc", out int number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Convertion failed");
        }
    }
}
