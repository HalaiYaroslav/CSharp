using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registry_Application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuViewDoctors_Click(object sender, EventArgs e)
        {
            
            Doctors GoToDoc = new Doctors();
            GoToDoc.Show();
        }

        private void menuEditDoctors_Click(object sender, EventArgs e)
        {
            EditingDoctors GoToEdDoc = new EditingDoctors();
            GoToEdDoc.Show();
        }

        private void menuViewPatients_Click(object sender, EventArgs e)
        {
            Patients GoToPat = new Patients();
            GoToPat.Show();
        }

        private void menuEditPatient_Click(object sender, EventArgs e)
        {
            EditingPatients GoToEdPat = new EditingPatients();
            GoToEdPat.Show();
        }       

        private void menuAboutProgram_Click(object sender, EventArgs e)
        {
            About GoToAb = new About();            
            GoToAb.Show();            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            try
            { Cure.Deserialize(); }
            catch { MessageBox.Show("Не був завантажений файл Cures.xml"); }
            try
            { Doctor.Deserialize(); }
            catch { MessageBox.Show("Не був завантажений файл Doctors.xml"); }
            try
            { Patient.Deserialize(); }
            catch { MessageBox.Show("Не був завантажений файл Patients.xml"); }
            try
            { Medication.Deserialize(); }
            catch { MessageBox.Show("Не був завантажений файл Medications.xml"); }
            try
            { Recipe.Deserialize(); }
            catch { MessageBox.Show("Не був завантажений файл Recipes.xml"); }
            try
            { Cabinet.Deserialize(); }
            catch { MessageBox.Show("Не був завантажений файл Cabinets.xml"); }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuMadication_Click(object sender, EventArgs e)
        {
            CreateMadication GoToCreateMedic = new CreateMadication();
            GoToCreateMedic.Show();
        }

        private void menuRecipe_Click(object sender, EventArgs e)
        {
            CreateRecipe GoToCreateRecipe = new CreateRecipe();
            GoToCreateRecipe.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Doctor.Serialize();
            Patient.Serialize();
            Cure.Serialize();
            Cabinet.Serialize();
            Medication.Serialize();
            Recipe.Serialize();
        }
    }
}
