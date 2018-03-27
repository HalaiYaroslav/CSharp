using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship_M2M__M2O
{
    class Medication
    {
        public static Dictionary<Guid, Medication> medicationS = new Dictionary<Guid, Medication>();

        public Guid _id { get; private set; }  
        public List<Patient> Medication_sPatients
        {
            get
            {
                List<Patient> patnts = new List<Patient>();
                foreach (Cure cure in Cure.cureS.Values)
                    if (cure.Medication._id == this._id) patnts.Add(cure.Patient);
                return patnts;
            }
        }      

        public Medication()
        {
            _id = Guid.NewGuid();
            medicationS.Add(_id, this);
        }
    }
}
