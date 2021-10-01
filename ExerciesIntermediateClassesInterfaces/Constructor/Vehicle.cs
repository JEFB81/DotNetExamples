using System;

namespace ExerciesIntermediateClassesInterfaces.Constructor
{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized!");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine($"Vehicle is being initialized with registration Number {registrationNumber}");
        }
    }
}
