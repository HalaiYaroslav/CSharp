using System;
using System.Windows.Forms;

namespace CodingAndDecoding
{
    public partial class SimpleReiteration : Form
    {
        public SimpleReiteration()
        {
            InitializeComponent();
            lb_TrackBarStatus.Text = "0";
        }

        private void btn_Encode_Click(object sender, EventArgs e)
        {
            if(cmbx_TypeOfCoding.SelectedIndex == 0)
            {
                string inputNumber = tb_Input.Text;               
                if (inputNumber.Length == trackBar_CofInfoElemens.Value)
                {
                    tb_Output.Text = tb_Input.Text + tb_Input.Text;
                }
                else if (inputNumber.Length > trackBar_CofInfoElemens.Value)
                {
                    tb_Output.Text = tb_Input.Text + tb_Input.Text.Substring(0, trackBar_CofInfoElemens.Value);
                }
                else MessageBox.Show("Check the count of information elements!");
            }
            else if(cmbx_TypeOfCoding.SelectedIndex == 1)
            {
                string inputNumber = tb_Input.Text;
                if (inputNumber.Length == trackBar_CofInfoElemens.Value)
                {
                    MessageBox.Show("Check the count of information elements!");
                }
                else if (inputNumber.Length > trackBar_CofInfoElemens.Value)
                {
                    tb_Output.Text = tb_Input.Text.Substring(0, tb_Input.Text.Length - trackBar_CofInfoElemens.Value);
                }
                else MessageBox.Show("Check the count of information elements!");
            }
        }
        private void trackBar_CofInfoElemens_Scroll(object sender, EventArgs e)
        {
            lb_TrackBarStatus.Text = trackBar_CofInfoElemens.Value.ToString();
        }        
    }
}
