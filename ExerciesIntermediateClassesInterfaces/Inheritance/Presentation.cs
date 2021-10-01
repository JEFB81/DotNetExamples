using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesIntermediateClassesInterfaces.Inheritance
{
    public class Presentation
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            System.Console.WriteLine("Object was copied to clipboard");
        }
        public void Print()
        {
            System.Console.WriteLine($"Width set: {Width}");
        }

        public void Duplicate()
        {
            System.Console.WriteLine("Object was dupliated");
        }
    }
}
