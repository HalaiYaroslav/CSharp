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
    public partial class CreateMadication : Form
    {
        public CreateMadication()
        {
            InitializeComponent();
        }

        private void CreateMadication_Load(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            lstb_ViewMedications.DataSource = null;
            lstb_ViewMedications.DataSource = Medication.ItemsOfClass.Values.ToList();
        }

        private void lstb_ViewMedications_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                tb_Action.Text = ((Medication)lstb_ViewMedications.SelectedItem).Action;
                tb_Contraindications.Text = ((Medication)lstb_ViewMedications.SelectedItem).Contraindications;
                tb_Cost.Text = ((Medication)lstb_ViewMedications.SelectedItem).Cost.ToString();
                tb_Name.Text = ((Medication)lstb_ViewMedications.SelectedItem).Name;
            }
            catch { }          
        }

        private void btn_AddMedication_Click(object sender, EventArgs e)
        {
            try
            {
                Medication newMedication = new Medication(tb_Name.Text, tb_Action.Text, tb_Contraindications.Text, int.Parse(tb_Cost.Text));              
                RefreshListBox();
            }
            catch(Exception exeption)
            {
                MessageBox.Show(exeption.ToString(),"", MessageBoxButtons.OK);
            }            
        }

        private void btn_EditMedication_Click(object sender, EventArgs e)
        {try
            {
                ((Medication)lstb_ViewMedications.SelectedItem).Name = tb_Name.Text;
                ((Medication)lstb_ViewMedications.SelectedItem).Action = tb_Action.Text;
                ((Medication)lstb_ViewMedications.SelectedItem).Contraindications = tb_Contraindications.Text;
                ((Medication)lstb_ViewMedications.SelectedItem).Cost = int.Parse(tb_Cost.Text);
            }
            catch
            {
                MessageBox.Show("Fill all fields!", "Not all fields are field", MessageBoxButtons.OK);
            }
        }

        private void btn_RemoveMedication_Click(object sender, EventArgs e)
        {
            try
            {
                Medication.ItemsOfClass.Remove(((Medication)lstb_ViewMedications.SelectedItem).Id);
                RefreshListBox();
            }
            catch { }
        }
    }
}
