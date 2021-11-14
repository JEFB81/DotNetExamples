using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class Composite : Component
    {
        readonly List<Component> children = new();

        // Constructor
        public Composite(string name) 
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
            // Recursively display child nodes
            foreach (Component component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
}
