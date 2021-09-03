using System.Collections.Generic;

namespace ExerciesIntermediateClassesInterfaces.MethodOverriding
{
    public class Canvas
    {

        public void DrawShapes(List<Shape> shapes) 
        {
            foreach (var shape in shapes)
            {
                // this is what we call polymorphism - can have many forms 
                shape.Draw();
            }
        }
    }
}
