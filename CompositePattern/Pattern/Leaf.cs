﻿using System;

namespace CompositePattern
{
    /// <summary>
    /// The 'Leaf' class
    /// </summary>
    public class Leaf : Component
    {
        public Leaf(string name) :base (name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
