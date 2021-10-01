using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesIntermediateClassesInterfaces.Conversions
{
    public class PersonParse
    {
        public static void UsePerson()
        {
            //var person = new Person { Name = "Jhaner" };
            var person = Person.Parse("Jhaner");
            person.Introduce("John");
        }
    }
}
