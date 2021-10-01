using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesIntermediateClassesInterfaces.Indexer
{
    public class ProcessIndexer
    {
        public void CookieExample()
        {
            var cookie = new Cookie();
            cookie["name"] = "Jhaner";

            Console.WriteLine(cookie["name"]);
        }

    }
}
