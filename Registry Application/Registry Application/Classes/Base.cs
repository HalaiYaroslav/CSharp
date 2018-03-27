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
    class Base<T> where T: Base<T>
    {
        public static Dictionary<Guid, T> ItemsOfClass = new Dictionary<Guid, T>();
        [DataMember]
        public Guid Id { get; protected set; }

        public Base()
        {
            Id = Guid.NewGuid();
            ItemsOfClass.Add(Id, (T)this);
        }
    }
}
