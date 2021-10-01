using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciesIntermediateClassesInterfaces.Indexer
{
    // Example of an Indexer to use with the dictionary
    public class Cookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expire { get; set; }

        public Cookie()
        {
            _dictionary = new Dictionary<string, string>();
        }
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
