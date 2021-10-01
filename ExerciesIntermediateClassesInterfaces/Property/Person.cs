using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesIntermediateClassesInterfaces.Property
{
    public class Person
    {
        // non-auto implemented property
        //private DateTime _birthdate;

        //public DateTime Birthdate
        //{
        //    get { return _birthdate; }
        //    set { _birthdate = value; }
        //}

        // auto implemented property
        // creates internally a private field
        public DateTime Birthdate { get; set; }

        // can be only set in the constructor
        // it means its readonly
        public DateTime Birthdate2 { get; private set; }



        public Person(DateTime birthdate)
        {
            Birthdate2 = birthdate;
        }

        // not set, because the age should be calculated for the person
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}
