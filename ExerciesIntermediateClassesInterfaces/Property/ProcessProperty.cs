using System;
/**
 * What is a Property
   - a class memeber that encapsulates a getter/setter for accessing a field
   we need a propertie to create a getter/setter with less code
   -
   we can use auto implemented properties.
   c# will create a private field automatically for us.
 */
namespace ExerciesIntermediateClassesInterfaces.Property
{
    public class ProcessProperty
    {
        public void Property()
        {
            // via the constructor
            var person = new Person(new DateTime(1982, 2, 2))
            {
                Birthdate = new DateTime(1981, 1, 1)
            };

            Console.WriteLine($"your age :{person.Age}");

            Console.WriteLine(person.Birthdate);
            Console.WriteLine(person.Birthdate2);
        }

    }
}
