using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynchronousModel
{
    class Incapsulator
    {
        public Label StateOutputLabel { get; set; }
        public double FirstOperand { get; set; }
        public double SecondOperand { get; set; }
        public char Sign { get; set; }

        public Incapsulator(Label label, double firstOperand, double secondOperand, char sign)
        {
            StateOutputLabel = label;
            FirstOperand = firstOperand;
            SecondOperand = secondOperand;
            Sign = sign;
        }
    }
}
