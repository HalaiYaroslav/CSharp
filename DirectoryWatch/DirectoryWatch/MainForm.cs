using System;
using System.Windows.Forms;
using System.IO;

namespace DirectoryWatch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBox_Files.Items.Clear();
                listBox_Folders.Items.Clear();

                textBox.Text = comboBox.Text;

                string path = comboBox.Text;

                char[] symbols = { '\\', '/', ' ' };

                GetShowFolders(path, symbols);
                GetShowFiles(path, symbols);

            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Directory not found. Check your path.", "System.IO.DirectoryNotFoundException", MessageBoxButtons.RetryCancel);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found. Check your path.", "System.IO.FileNotFoundException", MessageBoxButtons.RetryCancel);
            }
        }

        private void btn_AddComBoxText_Click(object sender, EventArgs e)
        {
            comboBox.Items.Add(textBox.Text);
        }        

        private void GetShowFolders(string path, char[] symbols)
        {
            string[] folders = Directory.GetDirectories(path);
            for (int i = 0; i < folders.Length; i++)
            {
                folders[i] = folders[i].Replace(path, "").TrimStart(symbols);
                listBox_Folders.Items.Add(folders[i]);
            }
        }

        private void GetShowFiles(string path, char[] symbols)
        {
            string[] files = Directory.GetFiles(path);


            for (int i = 0; i < files.Length; i++)
            {
                files[i] = files[i].Replace(path, "").TrimStart(symbols);
                listBox_Files.Items.Add(files[i]);
            }
        }

        private void listBox_Folders_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBox_Files.Items.Clear();
                listBox_Folders.Items.Clear();

                textBox.Text = comboBox.Text;

                string path = comboBox.Text;

                char[] symbols = { '\\', '/', ' ' };

                GetShowFolders(path, symbols);
                GetShowFiles(path, symbols);

            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Directory not found. Check your path.", "System.IO.DirectoryNotFoundException", MessageBoxButtons.RetryCancel);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found. Check your path.", "System.IO.FileNotFoundException", MessageBoxButtons.RetryCancel);
            }
        }

    }
}

