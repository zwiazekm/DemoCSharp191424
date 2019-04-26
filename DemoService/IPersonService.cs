using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DemoService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPersonService
    {

        [OperationContract]
        Person GetPerson(int PersonID);

        [OperationContract]
        void WritePerson(Person newPerson);

        [OperationContract]
        List<Person> Persons();


    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Person
    {
        [DataMember]
        public int PersonID { get; set; }
        [DataMember]
        public string PersonName { get; set; }
        [DataMember]
        public int PersonAge { get; set; }
    }
}
