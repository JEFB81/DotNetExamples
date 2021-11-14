using System;

namespace CompositePattern.Example
{
    /// <summary>
    /// The 'Leaf' class
    /// </summary>
    public class PrimitiveElement : DrawingElement
    {
        public PrimitiveElement(string name) : base (name)
        {
        }

        public override void Add(DrawingElement d)
        {
            throw new NotImplementedException();
        }

        public override void Remove(DrawingElement d)
        {
            throw new NotImplementedException();
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) + " " + name);
        }
    }
}
