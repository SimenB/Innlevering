using System;

namespace CookieBakery
{
    public sealed class Person
    {
        public String Name { get; private set; }

        // No unnamed people here
        private Person()
        {   
        }

        public Person(String name)
        {
            this.Name = name;
        }
    }
}
