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
    public partial class EditingPatients : Form
    {
        public EditingPatients()
        {
            InitializeComponent();
        }

        private void EditingPatients_Load(object sender, EventArgs e)
        {
            RefreshListBoxes();
        }

        private void RefreshListBoxes()
        {
            lstb_ViewDoctors.DataSource = null;
            lstb_ViewPatients.DataSource = null;
            lstb_ViewRecipes.DataSource = null;

            lstb_ViewDoctors.DataSource = Doctor.ItemsOfClass.Values.ToList();
            lstb_ViewPatients.DataSource = Patient.ItemsOfClass.Values.ToList();
            lstb_ViewRecipes.DataSource = Recipe.ItemsOfClass.Values.ToList();
        }

        private void lstb_ViewPatients_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                tb_Name.Text = ((Patient)lstb_ViewPatients.SelectedItem).Name;
                tb_SureName.Text = ((Patient)lstb_ViewPatients.SelectedItem).SureName;
                tb_Address.Text = ((Patient)lstb_ViewPatients.SelectedItem).Address;
                tb_PhoneNumb.Text = ((Patient)lstb_ViewPatients.SelectedItem).PhoneNumber.ToString();
                tb_Disease.Text = ((Patient)lstb_ViewPatients.SelectedItem).Resipe.Disease;
                tb_Date.Text = ((Patient)lstb_ViewPatients.SelectedItem).Resipe.Date;                
            }
            catch { }
        }

        private void btn_AddNewPatient_Click(object sender, EventArgs e)
        {
            try
            {                
                Patient newPatient = new Patient(tb_Name.Text, tb_SureName.Text, tb_Address.Text, int.Parse(tb_PhoneNumb.Text), ((Recipe)lstb_ViewRecipes.SelectedItem));                
                RefreshListBoxes();
            }
            catch
            {
                MessageBox.Show("Fill all field!", "Fields not fill", MessageBoxButtons.OK);
            }
        }

        private void btn_EditPatient_Click(object sender, EventArgs e)
        {
            try
            {
                ((Patient)lstb_ViewPatients.SelectedItem).Name = tb_Name.Text;
                ((Patient)lstb_ViewPatients.SelectedItem).SureName = tb_SureName.Text;
                ((Patient)lstb_ViewPatients.SelectedItem).Address = tb_Address.Text;
                ((Patient)lstb_ViewPatients.SelectedItem).PhoneNumber = int.Parse(tb_PhoneNumb.Text);                
                ((Patient)lstb_ViewPatients.SelectedItem).Resipe.Disease = tb_Disease.Text;
                ((Patient)lstb_ViewPatients.SelectedItem).Resipe.Date = tb_Date.Text;
                RefreshListBoxes();
            }
            catch
            {
                MessageBox.Show("Fill all field!", "Fields not fill", MessageBoxButtons.OK);                
            }
        }

        private void btn_RemovePatient_Click(object sender, EventArgs e)
        {
            try
            {
                Patient.ItemsOfClass.Remove(((Patient)lstb_ViewPatients.SelectedItem).Id);                
                RefreshListBoxes();
            }
            catch { }
        }

        private void btn_AddDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                ((Patient)lstb_ViewPatients.SelectedItem).DoctorsList.Add(((Doctor)lstb_ViewDoctors.SelectedItem));
            }
            catch { }
        }

        private void btn_AddRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                ((Patient)lstb_ViewPatients.SelectedItem).Resipe = (((Recipe)lstb_ViewRecipes.SelectedItem));
            }
            catch { }
        }
    }
}
