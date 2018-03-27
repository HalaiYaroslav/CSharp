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
    class Medication : Base<Medication>
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Action { get; set; }
        [DataMember]
        public string Contraindications { get; set; }
        [DataMember]
        public double Cost { get; set; }        

        public Medication(string name, string action, string contraindications, double cost)
        {
            Name = name;
            Action = action;
            Contraindications = contraindications;
            Cost = cost;
        }

        public override string ToString()
        {
            return Name;
        }

        static public void Serialize()
        {
            DataContractSerializer serialization = new DataContractSerializer(typeof(Dictionary<Guid, Medication>));
            FileStream file = new FileStream("Medications.xml", FileMode.Create);
            serialization.WriteObject(file, ItemsOfClass);
            file.Close();
        }

        static public void Deserialize()
        {
            DataContractSerializer serialization = new DataContractSerializer(typeof(Dictionary<Guid, Medication>));
            FileStream file = new FileStream("Medications.xml", FileMode.Open);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(file, new XmlDictionaryReaderQuotas());
            ItemsOfClass = (Dictionary<Guid, Medication>)serialization.ReadObject(reader, true);
            file.Close();
        }
    }
}
