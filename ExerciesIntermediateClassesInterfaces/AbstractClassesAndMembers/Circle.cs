namespace ExerciesIntermediateClassesInterfaces.AbstractClassesAndMembers
{
    public class Circle : Shape
    {

        public int Radius { get; set; }

        // this method is mandatory because of the abstraction
        public override void Draw()
        {
            // you can write any code specific to the class itself

            System.Console.WriteLine("Draw a Circle");
        }
    }
}
