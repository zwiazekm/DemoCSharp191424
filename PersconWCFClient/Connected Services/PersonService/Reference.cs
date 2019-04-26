﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersconWCFClient.PersonService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/DemoService")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonAgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PersonNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PersonAge {
            get {
                return this.PersonAgeField;
            }
            set {
                if ((this.PersonAgeField.Equals(value) != true)) {
                    this.PersonAgeField = value;
                    this.RaisePropertyChanged("PersonAge");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PersonID {
            get {
                return this.PersonIDField;
            }
            set {
                if ((this.PersonIDField.Equals(value) != true)) {
                    this.PersonIDField = value;
                    this.RaisePropertyChanged("PersonID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PersonName {
            get {
                return this.PersonNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonNameField, value) != true)) {
                    this.PersonNameField = value;
                    this.RaisePropertyChanged("PersonName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PersonService.IPersonService")]
    public interface IPersonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPerson", ReplyAction="http://tempuri.org/IPersonService/GetPersonResponse")]
        PersconWCFClient.PersonService.Person GetPerson(int PersonID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPerson", ReplyAction="http://tempuri.org/IPersonService/GetPersonResponse")]
        System.Threading.Tasks.Task<PersconWCFClient.PersonService.Person> GetPersonAsync(int PersonID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/WritePerson", ReplyAction="http://tempuri.org/IPersonService/WritePersonResponse")]
        void WritePerson(PersconWCFClient.PersonService.Person newPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/WritePerson", ReplyAction="http://tempuri.org/IPersonService/WritePersonResponse")]
        System.Threading.Tasks.Task WritePersonAsync(PersconWCFClient.PersonService.Person newPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/Persons", ReplyAction="http://tempuri.org/IPersonService/PersonsResponse")]
        PersconWCFClient.PersonService.Person[] Persons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/Persons", ReplyAction="http://tempuri.org/IPersonService/PersonsResponse")]
        System.Threading.Tasks.Task<PersconWCFClient.PersonService.Person[]> PersonsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonServiceChannel : PersconWCFClient.PersonService.IPersonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonServiceClient : System.ServiceModel.ClientBase<PersconWCFClient.PersonService.IPersonService>, PersconWCFClient.PersonService.IPersonService {
        
        public PersonServiceClient() {
        }
        
        public PersonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PersconWCFClient.PersonService.Person GetPerson(int PersonID) {
            return base.Channel.GetPerson(PersonID);
        }
        
        public System.Threading.Tasks.Task<PersconWCFClient.PersonService.Person> GetPersonAsync(int PersonID) {
            return base.Channel.GetPersonAsync(PersonID);
        }
        
        public void WritePerson(PersconWCFClient.PersonService.Person newPerson) {
            base.Channel.WritePerson(newPerson);
        }
        
        public System.Threading.Tasks.Task WritePersonAsync(PersconWCFClient.PersonService.Person newPerson) {
            return base.Channel.WritePersonAsync(newPerson);
        }
        
        public PersconWCFClient.PersonService.Person[] Persons() {
            return base.Channel.Persons();
        }
        
        public System.Threading.Tasks.Task<PersconWCFClient.PersonService.Person[]> PersonsAsync() {
            return base.Channel.PersonsAsync();
        }
    }
}