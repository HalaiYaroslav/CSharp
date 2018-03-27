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
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
        }

        private void Doctors_Load(object sender, EventArgs e)
        {            
            try
            {
                RefreshListBoxes();
                RefreshTextBoxes();
            }
            catch { }
        }

        private void listBox_DoctorsView_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_ViewPatients.ClearSelected();

            tb_Post.Show();
            tb_Floor.Show();
            tb_Cabinet.Show();

            lb_Cabinet.Show();
            lb_Floor.Show();
            lb_Post.Show();

            try
            {
                tb_Address.Text = ((Doctor)listBox_DoctorsView.SelectedItem).Address;
                tb_PhoneNumber.Text = (((Doctor)listBox_DoctorsView.SelectedItem).PhoneNumber).ToString(); ;
                tb_Post.Text = ((Doctor)listBox_DoctorsView.SelectedItem).Post;
                tb_Cabinet.Text = (((Doctor)listBox_DoctorsView.SelectedItem).Cabinet.Number).ToString();
                tb_Floor.Text = (((Doctor)listBox_DoctorsView.SelectedItem).Cabinet.Floor).ToString();
                listBox_ViewPatients.DataSource = ((Doctor)listBox_DoctorsView.SelectedItem).PatiensList;

            }
            catch { }
        }

        private void RefreshTextBoxes()
        {
            tb_Address.Clear();
            tb_Cabinet.Clear();
            tb_Floor.Clear();
            tb_PhoneNumber.Clear();
            tb_Post.Clear();
        }

        private void RefreshListBoxes()
        {
            listBox_ViewPatients.DataSource = null;
            listBox_ViewPatients.DataSource = Patient.ItemsOfClass.Values.ToList();

            listBox_DoctorsView.DataSource = null;
            listBox_DoctorsView.DataSource = Doctor.ItemsOfClass.Values.ToList();
        }

        private void listBox_ViewPatients_MouseClick(object sender, MouseEventArgs e)
        {
            listBox_DoctorsView.ClearSelected();
            tb_Cabinet.Clear();
            tb_Floor.Clear();
            tb_Post.Clear();

            tb_Post.Hide();
            tb_Floor.Hide();
            tb_Cabinet.Hide();

            lb_Cabinet.Hide();
            lb_Floor.Hide();
            lb_Post.Hide();

            try
            {
                tb_Address.Text = ((Patient)listBox_ViewPatients.SelectedItem).Address;
                tb_PhoneNumber.Text = (((Patient)listBox_ViewPatients.SelectedItem).PhoneNumber).ToString();
            }
            catch { }
        }

        private void btn_RefreshListBoxes_Click(object sender, EventArgs e)
        {
            RefreshListBoxes();
        }
    }
}
