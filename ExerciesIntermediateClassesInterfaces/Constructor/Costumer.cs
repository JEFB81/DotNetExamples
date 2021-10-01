using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesIntermediateClassesInterfaces.Constructor
{
    // passing or calling other contructors with this() method, makes the code hard to maintain
    // try not to do this
    public class Costumer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Order> Orders = new List<Order>();

        public Costumer()
        {
            // een optie om de lijst te initializeren
            // dont do this here without a input parameter in the constructor
            // Orders = new List<Order>();
        }

        public Costumer(int id)
        {
            Id = id;
        }

        public Costumer(int id, string name)
            : this(id) // call contructor with 1 parameter, pass control to an other constructor
        {
            Name = name;
        }
    }
}
