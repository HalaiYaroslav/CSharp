using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFinder
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        DirectoryInfo directory;
        ContentViewer contentViewer;

        private void PathInput_TextChanged(object sender, EventArgs e)
        {
            directory = new DirectoryInfo(PathInput.Text);            

            try
            {
                ResetExeptionLabel();

                LoadDirectories(directory);
                LoadFiles(directory);
            }
            catch (DirectoryNotFoundException)
            {                
                ExceptionsLabel.BackColor = Color.Red;
                ExceptionsLabel.ForeColor = Color.White;
                ExceptionsLabel.Text = "Directory not exist.";
            }
        }

        private void AvailablePathsSelector_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PathInput.Text = AvailablePathsSelector.SelectedItem.ToString();
        }       
        
        private void ResetExeptionLabel()
        {
            ExceptionsLabel.BackColor = Color.Transparent;
            ExceptionsLabel.ForeColor = Color.Transparent;
            ExceptionsLabel.Text = "";
        }

        private void LoadDirectories(DirectoryInfo directoryInfo)
        {
            DirectoriesSelector.DataSource = directoryInfo.GetDirectories().ToList();
        }

        private void LoadFiles(DirectoryInfo directoryInfo)
        {
            FilesSelector.DataSource = directoryInfo.GetFiles().ToList();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            if (directory != null && directory.FullName != directory.Root.Name)
            {
                PathInput.Text = directory.Parent.FullName;
            }
        }

        private void DirectoriesSelector_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (directory != null)
            {
                PathInput.Text += @"\" + DirectoriesSelector.SelectedItem.ToString();
            }
        }

        private void SavePathButton_Click(object sender, EventArgs e)
        {
            if(directory.Exists)
            {
                AvailablePathsSelector.Items.Add(PathInput.Text);
            }
        }

        private void FilesSelector_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (directory != null)
            {
                try
                {
                    var file = new FileInfo(directory.FullName + @"\" + FilesSelector.SelectedItem.ToString());

                    contentViewer = new ContentViewer();
                    contentViewer.fileInfo = file;
                    contentViewer.MainWindow = this;

                    Enabled = false;

                    contentViewer.Show();
                }
                catch (FileNotFoundException)
                {
                    ExceptionsLabel.BackColor = Color.Red;
                    ExceptionsLabel.ForeColor = Color.White;
                    ExceptionsLabel.Text = "File not exist.";
                }
            }
        }

        private void FindFileButton_Click(object sender, EventArgs e)
        {
            if (directory != null && FileNameInput.Text != string.Empty)
            {
                try
                {
                    var file = new FileInfo(directory.Name + @"\" +FileNameInput.Text);

                    contentViewer = new ContentViewer();
                    contentViewer.fileInfo = file;
                    contentViewer.MainWindow = this;

                    Enabled = false;

                    contentViewer.Show();
                }                
                catch (FileNotFoundException)
                {
                    ExceptionsLabel.BackColor = Color.Red;
                    ExceptionsLabel.ForeColor = Color.White;
                    ExceptionsLabel.Text = "File not exist in the current directory.";
                }
            }
        }
    }
}
