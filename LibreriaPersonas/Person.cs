using System;
using System.Collections.Generic;

namespace LibreriaPersonas
{
    public class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            SurName = surname;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Name == person.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }
    }
}
