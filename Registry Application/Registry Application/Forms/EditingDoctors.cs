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
    public partial class EditingDoctors : Form
    {
        public EditingDoctors()
        {
            InitializeComponent();
        }               

        private void EditingDoctors_Load(object sender, EventArgs e)
        {
            lstb_ViewDoctors.DataSource = Doctor.ItemsOfClass.Values.ToList();
            listBox_ViewPatients.DataSource = Patient.ItemsOfClass.Values.ToList();
        }

        private void btn_AddNewDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                Cabinet newDoctorCabinet = new Cabinet(int.Parse(tbx_NumberOfCabinet.Text), int.Parse(tbx_Floor.Text));
                Doctor newDoctor = new Doctor(tbx_Name.Text, tbx_SureNAme.Text, tbx_Address.Text, int.Parse(tbx_PhoneNumber.Text), tbx_Post.Text, newDoctorCabinet);
                RefreshListBox();
            }
            catch
            {
                MessageBox.Show("Fill all field!", "Fields not fill", MessageBoxButtons.OK);
                if (tbx_Floor.Text == "") tbx_Floor.Focus();
                if (tbx_NumberOfCabinet.Text == "") tbx_NumberOfCabinet.Focus();
                if (tbx_Post.Text == "") tbx_Post.Focus();
                if (tbx_PhoneNumber.Text == "") tbx_PhoneNumber.Focus();
                if (tbx_Address.Text == "") tbx_Address.Focus();
                if (tbx_SureNAme.Text == "") tbx_SureNAme.Focus();
                if (tbx_Name.Text == "") tbx_Name.Focus();
            }
        }

        private void btn_EditDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                ((Doctor)lstb_ViewDoctors.SelectedItem).Name = tbx_Name.Text;
                ((Doctor)lstb_ViewDoctors.SelectedItem).SureName = tbx_SureNAme.Text;
                ((Doctor)lstb_ViewDoctors.SelectedItem).Address = tbx_Address.Text;
                ((Doctor)lstb_ViewDoctors.SelectedItem).PhoneNumber = int.Parse(tbx_PhoneNumber.Text);
                ((Doctor)lstb_ViewDoctors.SelectedItem).Post = tbx_Post.Text;
                ((Doctor)lstb_ViewDoctors.SelectedItem).Cabinet.Number = int.Parse(tbx_NumberOfCabinet.Text);
                ((Doctor)lstb_ViewDoctors.SelectedItem).Cabinet.Floor = int.Parse(tbx_Floor.Text);
                RefreshListBox();
            }
            catch
            {
                MessageBox.Show("Fill all field!", "Fields not fill", MessageBoxButtons.OK);
                if (tbx_Floor.Text == "") tbx_Floor.Focus();
                if (tbx_NumberOfCabinet.Text == "") tbx_NumberOfCabinet.Focus();
                if (tbx_Post.Text == "") tbx_Post.Focus();
                if (tbx_PhoneNumber.Text == "") tbx_PhoneNumber.Focus();
                if (tbx_Address.Text == "") tbx_Address.Focus();
                if (tbx_SureNAme.Text == "") tbx_SureNAme.Focus();
                if (tbx_Name.Text == "") tbx_Name.Focus();
            }
        }

        private void btn_RemoveDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                List<Guid> guidsObjForRemove = new List<Guid>();
                foreach (var cure in Cure.ItemsOfClass.Values)
                {
                    if (((Doctor)lstb_ViewDoctors.SelectedItem).Id == cure.DoctorID.Id)
                    {
                        guidsObjForRemove.Add(cure.Id);
                    }
                }
                foreach (var guid in guidsObjForRemove)
                    Cure.ItemsOfClass.Remove(guid);
                Doctor.ItemsOfClass.Remove(((Doctor)lstb_ViewDoctors.SelectedItem).Id);
                ClearTboxes();
                RefreshListBox();
            }
            catch { }
        }

        private void btn_AddPatientToDoctor_sList_Click(object sender, EventArgs e)
        {
            try
            {
                new Cure(((Doctor)lstb_ViewDoctors.SelectedItem), ((Patient)listBox_ViewPatients.SelectedItem));
            }
            catch { }
        }

        private void lstb_ViewDoctors_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                tbx_Name.Text = ((Doctor)lstb_ViewDoctors.SelectedItem).Name;
                tbx_SureNAme.Text = ((Doctor)lstb_ViewDoctors.SelectedItem).SureName;
                tbx_Address.Text = ((Doctor)lstb_ViewDoctors.SelectedItem).Address;
                tbx_PhoneNumber.Text = ((Doctor)lstb_ViewDoctors.SelectedItem).PhoneNumber.ToString();
                tbx_Post.Text = ((Doctor)lstb_ViewDoctors.SelectedItem).Post;
                tbx_NumberOfCabinet.Text = ((Doctor)lstb_ViewDoctors.SelectedItem).Cabinet.Number.ToString();
                tbx_Floor.Text = ((Doctor)lstb_ViewDoctors.SelectedItem).Cabinet.Floor.ToString();
            }
            catch { }
        }

        private void RefreshListBox()
        {
            lstb_ViewDoctors.DataSource = null;
            lstb_ViewDoctors.DataSource = Doctor.ItemsOfClass.Values.ToList();
        }    
        
        private void ClearTboxes()
        {
            tbx_Address.Clear();
            tbx_Floor.Clear();
            tbx_Name.Clear();
            tbx_PhoneNumber.Clear();
            tbx_Post.Clear();
            tbx_SureNAme.Clear();
            tbx_NumberOfCabinet.Clear();
        }   
    }
}
