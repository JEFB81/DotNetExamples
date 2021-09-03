namespace ExerciesIntermediateClassesInterfaces.MethodOverriding
{
    // this class doesnt have any own implementatio, then use abstract
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Position { get; set; }

        // use virtual to make it possible to overwriting this method
        public virtual void Draw() 
        {
        }
    }
}
