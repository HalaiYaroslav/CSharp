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
    [DataContract]
    class Cure : Base<Cure>
    {
        [DataMember]
        private Guid _doctorId;
        public Doctor DoctorID { get { return Doctor.ItemsOfClass[_doctorId]; } set { _doctorId = value.Id; } }

        [DataMember]
        private Guid _patientId;
        public Patient PatientID { get { return Patient.ItemsOfClass[_patientId]; } set { _patientId = value.Id; } }  
        
        public Cure(Doctor d, Patient p)
        {
            DoctorID = d;
            PatientID = p;
        }

        static public void Serialize()
        {
            DataContractSerializer serialization = new DataContractSerializer(typeof(Dictionary<Guid, Cure>));
            FileStream file = new FileStream("Cures.xml", FileMode.Create);
            serialization.WriteObject(file, ItemsOfClass);
            file.Close();
        }

        static public void Deserialize()
        {
            DataContractSerializer serialization = new DataContractSerializer(typeof(Dictionary<Guid, Cure>));
            FileStream file = new FileStream("Cures.xml", FileMode.Open);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(file, new XmlDictionaryReaderQuotas());
            ItemsOfClass = (Dictionary<Guid, Cure>)serialization.ReadObject(reader, true);
            file.Close();
        }
    }
}
