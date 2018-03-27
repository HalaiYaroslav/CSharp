using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace Registry_Application
{
    [DataContract]
    class Doctor : Base<Doctor>
    {
        [DataMember]
        private Guid _cabinetId;

        private const string CONNECTION_STRING =
            "Data Source=(local);Initial Catalog=DesignPatterns;Integrated Security=True";

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string SureName { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public long PhoneNumber { get; set; }
        [DataMember]
        public string Post { get; set; }

        public List<Patient> PatiensList
        {
            get
            {
                List<Patient> PL = new List<Patient>();
                foreach (var patient in Cure.ItemsOfClass.Values)
                    if (patient.DoctorID == this)
                        PL.Add(patient.PatientID);
                return PL;
            }
        }

        public Cabinet Cabinet
        {
            get
            {
                return Cabinet.ItemsOfClass[_cabinetId];
            }
            set
            {
                _cabinetId = value.Id;
            }
        }

        public Doctor(Guid id, string name, string surename, string address, string post, int phonenumber)
        {
            Id = id;
            Name = name;
            SureName = surename;
            Address = address;
            Post = post;
            PhoneNumber = phonenumber;
        }

        public Doctor(string name, string sureName, string address, int phoneNumber, string post, Cabinet c)
        {
            Name = name;
            SureName = sureName;
            Address = address;
            PhoneNumber = phoneNumber;
            Post = post;   
            Cabinet = c;                      
        }

        public override string ToString()
        {
            return SureName + " " + Name;
        }

        static public void Serialize()
        {
            DataContractSerializer serialization = new DataContractSerializer(typeof(Dictionary<Guid, Doctor>));
            FileStream file = new FileStream("Doctors.xml", FileMode.Create);
            serialization.WriteObject(file, ItemsOfClass);
            file.Close();
        }

        static public void Deserialize()
        {
            DataContractSerializer serialization = new DataContractSerializer(typeof(Dictionary<Guid, Doctor>));
            FileStream file = new FileStream("Doctors.xml", FileMode.Open);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(file, new XmlDictionaryReaderQuotas());
            ItemsOfClass = (Dictionary<Guid, Doctor>)serialization.ReadObject(reader, true);
            file.Close();
        }

        public static Doctor GetByID(Guid id)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;

                    command.CommandText = "SELECT TOP 1 * FROM [Doctor] WHERE [ID] = @ID";
                    command.Parameters.AddWithValue("@ID", id);

                    SqlDataReader reader = command.ExecuteReader();

                    // If the query returned a row, create the Customer object and return it.
                    if (reader.HasRows)
                    {
                        reader.Read();

                        string name = (string)reader["Name"]; 
                        string sureName = (string)reader["SureName"];
                        string address = (string)reader["Address"];
                        string post = (string)reader["Post"];
                        int phoneNumber = (int)reader["PhoneNumber"];

                        return new Doctor(id, name, sureName, address, post, phoneNumber);
                    }
                }
            }
            return null;
        }
    }
}
