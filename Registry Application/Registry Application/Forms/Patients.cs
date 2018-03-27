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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            RefreshListBoxes();
            lstbx_ViewPatients.DataSource = Patient.ItemsOfClass.Values.ToList();
        }        

        private void lstbx_ViewPatients_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                tb_Recipes.Text = (((Patient)lstbx_ViewPatients.SelectedItem).Resipe.MakeCertificateOfDisease());

                tb_Name.Text = ((Patient)lstbx_ViewPatients.SelectedItem).Name;
                tb_SureName.Text = ((Patient)lstbx_ViewPatients.SelectedItem).SureName;
                tb_Address.Text = ((Patient)lstbx_ViewPatients.SelectedItem).Address;
                tb_PhoneNumb.Text = ((Patient)lstbx_ViewPatients.SelectedItem).PhoneNumber.ToString();
                tb_Disease.Text = ((Patient)lstbx_ViewPatients.SelectedItem).Resipe.Disease;
                tb_Date.Text = ((Patient)lstbx_ViewPatients.SelectedItem).Resipe.Date;
            }
            catch { }
        }     

        private void RefreshListBoxes()
        {
            lstbx_ViewPatients.DataSource = null;
            lstbx_ViewPatients.DataSource = Patient.ItemsOfClass.Values.ToList();
            tb_Recipes.Clear();
        }

        private void btn_RefreshListBoxes_Click(object sender, EventArgs e)
        {
            RefreshListBoxes();
        }
    }
}
