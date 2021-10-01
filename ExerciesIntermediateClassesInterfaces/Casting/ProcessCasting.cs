using System;

namespace ExerciesIntermediateClassesInterfaces.Casting
{
    public class ProcessCasting
    {

        public void Run()
        {
            Text text = new Text();
            // upcasting
            Shape shape = text; // no convertion is required!
            // in memory both object text ans shape are reference to the same object
            // but the have different views

            text.Width = 200;
            shape.Width = 300;
            // dont forget that both are references to the same object

            Console.WriteLine($"{text.Width}");

            // DownCasting
            Shape shapeDownCasting = new Text(); // at runtime it type will be Text
            Text textDownCasting = (Text)shapeDownCasting;
            // so we can change the view (methods available in the derived class)

        }


    }
}
