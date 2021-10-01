using System;
using System.Collections;

namespace ExerciesIntermediateClassesInterfaces.BoxingUnBoxing
{
    public class Boxing
    {
        public void BoxingProcess()
        {
            // we can save any object type in an ArrayList
            // internally store alist of objects
            // it will have a performance penalty
            var list = new ArrayList();
            // boxing is executing on any type
            // no type saved
            list.Add(1);
            list.Add("Most");
            list.Add(DateTime.Today);

            var number = (int)list[1];
            Console.WriteLine(number);

        }
    }
}
