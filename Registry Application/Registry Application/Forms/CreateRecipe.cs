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
    public partial class CreateRecipe : Form
    {
        public CreateRecipe()
        {
            InitializeComponent();
        }

        private void CreateRecipe_Load(object sender, EventArgs e)
        {
            RefreshListBoxes();
        }

        private void RefreshListBoxes()
        {
            lstb_ViewDoctors.DataSource = null;
            lstb_ViewMedications.DataSource = null;            
            lstb_ViewRecipes.DataSource = null;

            lstb_ViewRecipes.DataSource = Recipe.ItemsOfClass.Values.ToList();            
            lstb_ViewMedications.DataSource = Medication.ItemsOfClass.Values.ToList();
            lstb_ViewDoctors.DataSource = Doctor.ItemsOfClass.Values.ToList();
        }

        private void btn_AddRecipe_Click(object sender, EventArgs e)
        {
            try{

                Recipe newRecipe = new Recipe(tb_Date.Text, tb_Disease.Text);
                RefreshListBoxes();
            }
            catch { }
        }

        private void btn_RemoveRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                Recipe.ItemsOfClass.Remove(((Recipe)lstb_ViewRecipes.SelectedItem).Id);
                RefreshListBoxes();
            }
            catch { }
        }

        private void btn_AddDoctorToRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                if (((Recipe)lstb_ViewRecipes.SelectedItem).Doctor == null)
                {
                    ((Recipe)lstb_ViewRecipes.SelectedItem).Doctor = ((Doctor)lstb_ViewDoctors.SelectedItem);
                    MessageBox.Show("Doctor" + ((Doctor)lstb_ViewDoctors.SelectedItem).SureName + " " + ((Doctor)lstb_ViewDoctors.SelectedItem).Name +  " added", "Succsess", MessageBoxButtons.OK);
                }
                else MessageBox.Show("This recipe already has a Doctor", "Creating Exeption", MessageBoxButtons.OK);
            }
            catch { }
        }

        private void btn_AddMedicationToRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                ((Recipe)lstb_ViewRecipes.SelectedItem).Medication = (((Medication)lstb_ViewMedications.SelectedItem));
                MessageBox.Show("Medication  \"" + ((Medication)lstb_ViewMedications.SelectedItem).Name + "\" added", "Succsess", MessageBoxButtons.OK);
            }
            catch(Exception exp) { MessageBox.Show(exp.ToString()); }
        }
    }
}
