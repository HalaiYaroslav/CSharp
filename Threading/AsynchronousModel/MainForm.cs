using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynchronousModel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void isCompleteButton_Click(object sender, EventArgs e)
        {
            var compute = new Func<double, double, char, double>(Compute);
            IAsyncResult asyncResult = compute.BeginInvoke(20, 30, '+', new AsyncCallback(), null);
            while (!asyncResult.IsCompleted)
            {
                if(BackColor != Color.Green)
                {
                    BackColor = Color.Green;                    
                }
                else
                {
                    BackColor = Color.Red;                    
                }
            }
        }

        private void endButton_Click(object sender, EventArgs e)
        {

        }

        private void callbackButton_Click(object sender, EventArgs e)
        {

        }

        private double Compute(double firstOperand, double secondOperand, char sign)
        {
            DoSomeWork();

            double result = 0;
            switch (sign)
            {
                case '+':
                    result = firstOperand + secondOperand;
                    break;
                case '-':
                    result = firstOperand - secondOperand;
                    break;
                case '*':
                    result = firstOperand * secondOperand;
                    break;
                case '/':
                    result = (secondOperand == 0) ? 0 : firstOperand / secondOperand;
                    break;
                default:
                    MessageBox.Show("Uknown operation.");
                    break;
            }

            DoSomeWork();
            
            return result;
        }        

        private void DoSomeWork()
        {
            Thread.Sleep(2000);
        }
    }
}
