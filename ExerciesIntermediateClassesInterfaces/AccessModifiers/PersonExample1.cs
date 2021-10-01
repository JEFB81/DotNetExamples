using System;

namespace ExerciesIntermediateClassesInterfaces.AccessModifiers
{
    public class PersonExample1
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
}
