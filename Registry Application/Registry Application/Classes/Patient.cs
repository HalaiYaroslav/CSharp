using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;

namespace Registry_Application
{
    [DataContract(IsReference = true)]
    class Patient : Base<Patient>
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string SureName { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public int PhoneNumber { get; set; }

        public List<Doctor> DoctorsList
        {
            get
            {
                List<Doctor> DL = new List<Doctor>();
                foreach (var doctor in Cure.ItemsOfClass.Values)
                    if (doctor.PatientID == this)
                        DL.Add(doctor.DoctorID);
                return DL;
            }
        }
        [DataMember]
        public Recipe Resipe { get; set; }
        
        public Patient(string name, string sureName, string address, int phoneNumber, Recipe r)
        {
            Name = name;
            SureName = sureName;
            Address = address;
            PhoneNumber = phoneNumber;
            Resipe = r;
        }               

        public override string ToString()
        {
            return SureName + " " + Name;
        }

        static public void Serialize()
        {
            DataContractSerializer serialization = new DataContractSerializer(typeof(Dictionary<Guid, Patient>));
            FileStream file = new FileStream("Patients.xml", FileMode.Create);
            serialization.WriteObject(file, ItemsOfClass);
            file.Close();
        }

        static public void Deserialize()
        {
            DataContractSerializer serialization = new DataContractSerializer(typeof(Dictionary<Guid, Patient>));
            FileStream file = new FileStream("Patients.xml", FileMode.Open);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(file, new XmlDictionaryReaderQuotas());
            ItemsOfClass = (Dictionary<Guid, Patient>)serialization.ReadObject(reader, true);
            file.Close();
        }
    }
}
