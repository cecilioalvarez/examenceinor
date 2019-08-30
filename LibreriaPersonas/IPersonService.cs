using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsLibrary
{
    public interface IPersonService
    {
        List<Person> FindAll();
        void InsertPerson(Person person);
    }
}
