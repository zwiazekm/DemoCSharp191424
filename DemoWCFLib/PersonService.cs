using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class PersonService : IPersonService
    {

        public Person GetPerson(int PersonID)
        {
            //TODO: Dorobic logike
            Person person = new Person()
            {
                PersonID = PersonID,
                PersonName = "Janko Walski",
                PersonAge = 46
            };
            return person;
        }

        public List<Person> Persons()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person()
            {
                PersonID = 1,
                PersonName = "Janko Walski",
                PersonAge = 46
            });
            //TODO: Dorobić wczytanie listy osób
            return persons;
        }

        public void WritePerson(Person newPerson)
        {

        }
    }
}
