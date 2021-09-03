namespace ExerciesIntermediateClassesInterfaces.SealedClassesAndMembers
{
    public class Rectangle : Shape
    {
        public int BorderSize  { get; set; }

        public sealed override void Draw()
        {
            // you can write any code specific to the class itself

            System.Console.WriteLine("Draw a Rectangle");
        }
    }
}
