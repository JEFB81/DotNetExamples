namespace ExerciesIntermediateClassesInterfaces.AbstractClassesAndMembers
{
    // abstract means that the class, doesnt have it own implementation
    // or is missing this and needs to be provided by its derived classes
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        // use virtual to make it possible to overwriting this method
        public abstract void Draw();

        public void Copy()
        {
            System.Console.WriteLine("Copy a shape in to clipboard");
        }

        public void Remove() 
        {
            System.Console.WriteLine("Remove a shape from clipboard");
        }
    }
}
