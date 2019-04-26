using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersconWCFClient.PersonService;

namespace PersconWCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonServiceClient client = new PersonServiceClient();
            Person person = client.GetPerson(1);
            Console.WriteLine(person.PersonName);
            Person newPerson = new Person()
            {
                PersonID = 12,
                PersonName = "Jerzy NOwak",

            };
            client.WritePerson(newPerson);
            Console.WriteLine("Lista osob:");
            foreach (var item in client.Persons())
            {
                Console.WriteLine(item.PersonName);
            }
        }
    }
}
