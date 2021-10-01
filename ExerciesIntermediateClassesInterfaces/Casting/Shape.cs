using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesIntermediateClassesInterfaces.Casting
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {
            Console.WriteLine("Drawing");
        }
    }
}
