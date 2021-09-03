using ExerciesIntermediateClassesInterfaces.MethodOverriding;
using AbsMem = ExerciesIntermediateClassesInterfaces.AbstractClassesAndMembers;
using System.Collections.Generic;

namespace ExerciesIntermediateClassesInterfaces
{
    public class Runner
    {
        // when creating new shape there isnt any impact on other classes
        public void RunMethodOverriding() 
        {
            
            var shapes = new List<Shape>
            {
                new Circle { Width = 100, Height = 200, Radius = 1},
                new Rectangle { Width = 200, Height = 300, BorderSize = 10}
            };

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }

        public void RunAbstractClassesAndMembers() 
        {

            //var shape = new AbsMem.Shape(); // it wont work because of abtract 

            var shapes = new List<AbsMem.Shape>
            {
                new AbsMem.Circle { Width = 100, Height = 200, Radius = 1},
                new AbsMem.Rectangle { Width = 200, Height = 300, BorderSize = 10}
            };
        }
    }
}
