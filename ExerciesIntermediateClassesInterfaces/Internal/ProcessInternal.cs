using ExerciesIntermediateClasses.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesIntermediateClassesInterfaces.Internal
{
    public class ProcessInternal
    {
        public static void AccessModifierInternal()
        {
            var customer = new Customer();
            // we create this we an dependency with this class and future change make this extra work
            // when removing the class or changing the method
            Customer customerInternal = new Customer();
            // tha class RateCalulator is not more visible here. the internal class is not accessible!
        }
    }
}
