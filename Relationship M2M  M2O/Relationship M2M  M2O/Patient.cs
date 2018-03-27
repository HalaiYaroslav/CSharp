using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship_M2M__M2O
{
    class Patient
    {
        public static Dictionary<Guid, Patient> patientS = new Dictionary<Guid, Patient>();

        public Guid _id { get; private set; }
        public List<Medication> Patient_sMedications
        {
            get
            {
                List<Medication> medns = new List<Medication>();
                foreach(Cure cure in Cure.cureS.Values)
                    if(_id == cure.Patient._id) medns.Add(cure.Medication);                    
                return medns;
            }
        }

        public Patient()
        {
            _id = Guid.NewGuid();
            patientS.Add(_id, this);
        }
    }
}
