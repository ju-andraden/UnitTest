using System;
using System.Collections.Generic;

namespace MyClasses.PersonClasses
{
    public class PersonManager
    {
        public Person CreatePerson(string first, string last, bool isSupervisor)
        {
            Person ret = null;

            if (!string.IsNullOrEmpty(first))
            {
                if (isSupervisor)
                {
                    ret = new Supervisor();
                }
                else
                {
                    ret = new Employee();
                }
                ret.FirstName = first;
                ret.LastName = last;
            }
            return ret;
        }

        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();

            people.Add(new Person() { FirstName = "Juliana", LastName = "Andrade" });
            people.Add(new Person() { FirstName = "Arthur", LastName = "Silva" });
            people.Add(new Person() { FirstName = "Maria", LastName = "Nascimento" });

            return people;
        }

        public List<Person> GetSupervisors()
        {
            List<Person> people = new List<Person>();

            people.Add(CreatePerson("Juliana", "Andrade", true));
            people.Add(CreatePerson("Arthur", "Silva", true));

            return people;
        }
    }
}
