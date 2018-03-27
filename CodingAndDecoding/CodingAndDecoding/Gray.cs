using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CodingAndDecoding
{
    public partial class Gray : Form
    {
        public Gray()
        {
            InitializeComponent();
        }

        private void btn_Encode_Click(object sender, EventArgs e)
        {            
            if (cmbx_TypeOfCoding.SelectedIndex == 0)
            {
                List<int> brokenNumber = new List<int>();
                if (rdbtn_Binary.Checked)
                {
                    foreach (char symb in tb_Input.Text)
                    {
                        brokenNumber.Add(int.Parse(symb.ToString()));
                    }
                }
                else if(rdbtn_Decimal.Checked)
                {
                    foreach (char symb in Convert.ToString(int.Parse(tb_Input.Text), 2))
                    {
                        brokenNumber.Add(int.Parse(symb.ToString()));
                    }
                }
                string result = brokenNumber[0].ToString();
                int j = 0;
                for (int i = 1; i < brokenNumber.Count; i++)
                {
                    if (Convert.ToBoolean(brokenNumber[j] ^ brokenNumber[i])) result += "1";
                    else if (!Convert.ToBoolean(brokenNumber[j] ^ brokenNumber[i])) result += "0";
                    j++;
                }
                tb_Output.Text = result;
            }            
            else if (cmbx_TypeOfCoding.SelectedIndex == 1)  
            {
                List<int> brokenNumber = new List<int>();
                if (rdbtn_Binary.Checked)
                {
                    foreach (char symb in tb_Input.Text)
                    {
                        brokenNumber.Add(int.Parse(symb.ToString()));
                    }
                }
                else if (rdbtn_Decimal.Checked)
                {
                    foreach (char symb in Convert.ToString(int.Parse(tb_Input.Text), 2))
                    {
                        brokenNumber.Add(int.Parse(symb.ToString()));
                    }
                }
                List<int> result = new List<int>();
                result.Add(brokenNumber[0]);
                int j = 0;
                for (int i = 1; i < brokenNumber.Count; i++)
                {
                    if (Convert.ToBoolean(result[j] ^ brokenNumber[i])) result.Add(1);
                    else if (!Convert.ToBoolean(result[j] ^ brokenNumber[i])) result.Add(0);
                    j++;
                }
                tb_Output.Text = string.Join("", result);
            }
            else MessageBox.Show("Select type of coding!");                
        }        
    }
}
