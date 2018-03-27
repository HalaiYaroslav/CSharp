using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CodingAndDecoding
{
    public partial class BCD : Form
    {
        public BCD()
        {
            InitializeComponent();
        }

        private void btn_Encode_Click(object sender, EventArgs e)
        {
            if (cmbx_TypeOfCoding.SelectedIndex == 0)
            {
                List<int> codeNumbers = new List<int>();                
                foreach (char symb in cmbx_Codes.SelectedItem.ToString())
                {
                    if (symb == '-') continue;
                    else codeNumbers.Add(int.Parse(symb.ToString()));
                }
                List<int> inputNumbers = new List<int>();
                foreach (char symb in tb_Input.Text)
                {
                    inputNumbers.Add(int.Parse(symb.ToString()));
                }
                string result = "";
                for(int i = 0; i < inputNumbers.Count; i++)
                {
                    for(int j = 0; j < codeNumbers.Count; j++)
                    {
                        if(inputNumbers[i] < codeNumbers[j])
                        {
                            result += "0";
                        }
                        else if(inputNumbers[i] >= codeNumbers[j])
                        {
                            result += "1";
                            inputNumbers[i] -= codeNumbers[j];
                        }
                    }

                }
                tb_Output.Text = result;                
            }
            else if (cmbx_TypeOfCoding.SelectedIndex == 1)
            {
                List<int> codeNumbers = new List<int>();
                foreach (char symb in cmbx_Codes.SelectedItem.ToString())
                {
                    if (symb == '-') continue;
                    else codeNumbers.Add(int.Parse(symb.ToString()));
                }
                List<int> inputNumbers = new List<int>();
                int digitCounter = 0;
                foreach (char symb in tb_Input.Text)
                {
                    inputNumbers.Add(int.Parse(symb.ToString()));
                    digitCounter++;
                }
                string result = "";
                int i = 1;
                int j = 0;
                while(i <= digitCounter/4)
                {
                    result +=   codeNumbers[0] * inputNumbers[j] +
                                codeNumbers[1] * inputNumbers[j+1] +
                                codeNumbers[2] * inputNumbers[j+2] +
                                codeNumbers[3] * inputNumbers[j+3];
                    j += 4;
                    i++;
                }
                tb_Output.Text = result;                
            }         
        }        
    }
}
