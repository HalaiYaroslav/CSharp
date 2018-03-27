using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CodingAndDecoding
{
    public partial class Berger : Form
    {
        public Berger()
        {
            InitializeComponent();
        }

        private void btn_Encode_Click(object sender, EventArgs e)
        {
            if (cmbx_TypeOfCoding.SelectedIndex == 0)
            {
                string inputNumber = tb_Input.Text;

                int countOfUnits = 0;
                foreach (char symb in inputNumber)
                {
                    if (symb == '1') countOfUnits++;
                }

                string resultPart = Convert.ToString(countOfUnits, 2);

                int chekingPart = 1;
                while (Math.Pow(2, chekingPart) < inputNumber.Length)
                {
                    chekingPart++;
                }

                while (chekingPart != resultPart.Length)
                {
                    resultPart = "0" + resultPart;
                }

                string invertedResultPart = (~Convert.ToInt32(resultPart)).ToString();
                /*
                for (int i = 0; i < resultPart.Length; i++)
                {
                    if (resultPart[i] == '1') invertedResultPart += "0";
                    else if (resultPart[i] == '0') invertedResultPart += "1";
                }*/

                tb_Output.Text = inputNumber + invertedResultPart;
            }
            else if (cmbx_TypeOfCoding.SelectedIndex == 1)
            {
                string inputNumber = tb_Input.Text;

                string chekingPart = inputNumber.Substring(inputNumber.Length - 4, 4);
                List<int> invertedChekingPart = new List<int>(); ;
                for (int i = 0; i < 4; i++)
                {
                    if (chekingPart[i] == '1') invertedChekingPart.Add(0);
                    else if (chekingPart[i] == '0') invertedChekingPart.Add(1);
                }

                int countOfOnes = (8 * invertedChekingPart[0] +
                    4 * invertedChekingPart[1] +
                    2 * invertedChekingPart[2] +
                    1 * invertedChekingPart[3]);

                int counter = 0;
                foreach (char symb in inputNumber)
                {
                    if (symb == '1' && countOfOnes == 0 || (inputNumber.Length - counter) == 4)
                    {
                        break;
                    }
                    else if (symb == '1') countOfOnes--;
                    counter++;
                }

                tb_Output.Text = inputNumber.Substring(0, counter);
            }
        }

    }
}
