using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship_M2M__M2O
{
    class Program
    {
        static void Main(string[] args)
        {
            Medication med1 = new Medication();
            Medication med2 = new Medication();
            Medication med3 = new Medication();
            Medication med4 = new Medication();

            Patient pat1 = new Patient();
            Patient pat2 = new Patient();
            Patient pat3 = new Patient();
            Patient pat4 = new Patient();

            new Cure(pat1, med1);
            new Cure(pat1, med4);

            new Cure(pat2, med2);
            new Cure(pat2, med3);

            new Cure(pat3, med1);
            new Cure(pat3, med2);

            new Cure(pat4, med3);
            new Cure(pat4, med4);

            Console.ReadKey();
                   
        }
    }
}
