using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesIntermediateClassesInterfaces.Fields
{
    public class Costumer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // can not be  change when is set
        public readonly List<Orders> Orders = new List<Orders>();

        // First Constructor
        public Costumer(int id)
        {
            //Orders = new List<Orders2>();
            Id = id;
        }

        // passing id to contructor with one parameter as input
        public Costumer(int id, string name)
        : this(id) // using the first constructor 
        {
            Name = name;
        }

        public void Promote()
        {
            // a readonly field can notbe assigned to
            // (except in a constructor or a variable initializer)
            //Orders = new List<Orders2>();
        }
    }
}
