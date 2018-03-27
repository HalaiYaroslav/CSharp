using System;
using System.Windows.Forms;

namespace CodingAndDecoding
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuItemGray_Click(object sender, EventArgs e)
        {
            Gray formGray = new Gray();
            formGray.Show();
        }

        private void menuItem_BCD_Click(object sender, EventArgs e)
        {
            BCD formBCD = new BCD();
            formBCD.Show();
        }

        private void menuItem_Berger_Click(object sender, EventArgs e)
        {
            Berger formBerger = new Berger();
            formBerger.Show();
        }

        private void menuItem_Elias_Click(object sender, EventArgs e)
        {
            Elias formElias = new Elias();
            formElias.Show();
        }

        private void menuItem_About_Click(object sender, EventArgs e)
        {
            About formAbout = new About();
            formAbout.Show();
        }

        private void menuItem_CWSR_Click(object sender, EventArgs e)
        {
            SimpleReiteration formSimpleReiteration = new SimpleReiteration();
            formSimpleReiteration.Show();
        }
    }
}
