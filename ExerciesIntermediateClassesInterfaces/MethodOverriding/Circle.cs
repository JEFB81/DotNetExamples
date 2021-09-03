namespace ExerciesIntermediateClassesInterfaces.MethodOverriding
{
    public class Circle : Shape
    {

        public int Radius { get; set; }

        public override void Draw()
        {
            // you can write any code specific to the class itself

            System.Console.WriteLine("Draw a Circle");
        }
    }
}
