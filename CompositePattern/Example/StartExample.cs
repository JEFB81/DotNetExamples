using System;

namespace CompositePattern.Example
{
    /// <summary>
    /// Composite Design Pattern
    /// </summary>
    public static class StartExample
    {
        public static void Pattern() 
        {
            var root = new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            // Create a branch
            var comp = new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);
            // Add and remove a PrimitiveElement
            var primitiveElement = new PrimitiveElement("Yellow Line");
            root.Add(primitiveElement);
            root.Remove(primitiveElement);
            // Recursively display nodes
            root.Display(1);
            // Wait for user
            Console.ReadKey();
        }
    }
}
