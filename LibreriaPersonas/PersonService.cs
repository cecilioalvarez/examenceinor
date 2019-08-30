using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaPersonas
{
    public class PersonService : IPersonService
    {
        private static List<Person> listaPersonas = new List<Person>();

        static  PersonService() {

            listaPersonas.Add(new Person("pepe", "perez", 20));
            listaPersonas.Add(new Person("juan", "sanchez", 40));
            listaPersonas.Add(new Person("ana", "gomez", 25));
        }

         
        public List<Person> FindAll()
        {
            return listaPersonas;
        }

        public void InsertPerson(Person person)
        {
            listaPersonas.Add(person);
         
        }
    }
}
