using CompositePattern.Example;
using System;
using System.Collections.Generic;

namespace CompositePattern
{    
    /// <summary>
    /// The 'Composite' class
    /// </summary>
    public class CompositeElement : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();

        public CompositeElement(string name) : base (name)
        {

        }

        public override void Add(DrawingElement element)
        {
            elements.Add(element);
        }

        public override void Remove(DrawingElement element)
        {
            elements.Remove(element);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) + "+ " + name);
            // Display each child element on this node
            foreach (DrawingElement element in elements)
            {
                element.Display(indent + 2);
            }
        }
    }
}
