using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesIntermediateClassesInterfaces.Conversions
{
    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Order> Orders { get; set; }

        public Person()
        {
            Orders = new List<Order>();
        }

        public Person(int id)
            : this()
        {
            Id = id;
        }

        public Person(int id, string name)
            : this(id)
        {
            Id = id;
            Name = name;
        }


        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, I'm {Name}");
        }

        public static Person Parse(string str)
        {
            return new Person { Name = str };
        }
    }
}
