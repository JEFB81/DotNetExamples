namespace ExerciesIntermediateClassesInterfaces.MethodOverriding
{
    public class Rectangle : Shape
    {
        public int BorderSize  { get; set; }

        public override void Draw()
        {
            // you can write any code specific to the class itself

            System.Console.WriteLine("Draw a Rectangle");
        }
    }
}
