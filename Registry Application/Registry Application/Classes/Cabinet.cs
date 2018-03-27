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
    class Cabinet : Base<Cabinet>
    {
        [DataMember]
        public int Number { get; set; }
        [DataMember]
        public int Floor { get; set; }

        public List<Doctor> ListOfDoctors
        {
            get
            {
                List<Doctor> LoD = new List<Doctor>();
                foreach (var doctor in Doctor.ItemsOfClass.Values)
                    if (doctor.Cabinet.Id == this.Id)
                        LoD.Add(doctor);
                return LoD;
            }
        }

        public Cabinet(int number, int floor)
        {
            Number = number;
            Floor = floor;
        }

        static public void Serialize()
        {
            DataContractSerializer serialization = new DataContractSerializer(typeof(Dictionary<Guid, Cabinet>));
            FileStream file = new FileStream("Cabinets.xml", FileMode.Create);
            serialization.WriteObject(file, ItemsOfClass);
            file.Close();
        }

        static public void Deserialize()
        {
            DataContractSerializer serialization = new DataContractSerializer(typeof(Dictionary<Guid, Cabinet>));
            FileStream file = new FileStream("Cabinets.xml", FileMode.Open);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(file, new XmlDictionaryReaderQuotas());
            ItemsOfClass = (Dictionary<Guid, Cabinet>)serialization.ReadObject(reader, true);
            file.Close();
        }
    }
}
