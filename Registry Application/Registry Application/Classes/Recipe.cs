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
    class Recipe :Base<Recipe>
    {
        [DataMember]
        public string Date { get; set; }
        [DataMember]
        public string Disease { get; set; }

        [DataMember]
        public Patient Patient { get; set; }
        [DataMember]
        public Doctor Doctor { get; set; }
        [DataMember]
        public Medication Medication { get; set; }  

        public Recipe(string date, string disease)
        {            
            Date = date;
            Disease = disease;
        }        
                
        public override string ToString()
        {
            return "Disease: " + Disease;
        }        

        public string MakeCertificateOfDisease()
        {
            string conclusion = "Disease: " + Disease + ".  Patient: " + Patient.SureName + " " + Patient.Name + ".  Doctor who cure: ";
            conclusion += Doctor.SureName + " " + Doctor.Name + " (" + Doctor.Post + ")";           
            conclusion += "   " + Medication.Name + " " + Medication.Cost + "uah" + "  Date: " + Date;            
            return conclusion;
        }

        static public void Serialize()
        {
            DataContractSerializer serialization = new DataContractSerializer(typeof(Dictionary<Guid, Recipe>));
            FileStream file = new FileStream("Recipes.xml", FileMode.Create);
            serialization.WriteObject(file, ItemsOfClass);
            file.Close();
        }

        static public void Deserialize()
        {
            DataContractSerializer serialization = new DataContractSerializer(typeof(Dictionary<Guid, Recipe>));
            FileStream file = new FileStream("Recipes.xml", FileMode.Open);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(file, new XmlDictionaryReaderQuotas());
            ItemsOfClass = (Dictionary<Guid, Recipe>)serialization.ReadObject(reader, true);
            file.Close();
        }
    }
}
