using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship_M2M__M2O
{
    class Cure
    {
        public static Dictionary<Guid, Cure> cureS = new Dictionary<Guid, Cure>();
        public Guid Id { get; private set; }

        private Guid _idPatient;
        public Patient Patient { get { return Patient.patientS[_idPatient]; } set { _idPatient = value._id; } }

        private Guid _idMedication;
        public Medication Medication { get { return Medication.medicationS[_idMedication]; } set { _idMedication = value._id; } }

        public Cure(Patient patient, Medication medication)
        {
            Id = Guid.NewGuid();
            cureS.Add(Id, this);
            Patient = patient;
            Medication = medication;
        }
    }
}
