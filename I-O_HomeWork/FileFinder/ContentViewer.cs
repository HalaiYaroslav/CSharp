using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace FileFinder
{
    public partial class ContentViewer : Form
    {
        public ContentViewer()
        {
            InitializeComponent();
        }

        public MainWindow MainWindow;
        public FileInfo fileInfo;

        private void ContentViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindow.Enabled = true;
        }

        private void ContentViewer_Load(object sender, EventArgs e)
        {
            FileContentViewer.ScrollBars = ScrollBars.Both;

            if (fileInfo != null)
            {
                try
                {
                    using (StreamReader streamReader = File.OpenText(fileInfo.FullName))
                    {
                        string read = null;
                        while ((read = streamReader.ReadLine()) != null)
                        {
                            FileContentViewer.Text += read;
                        }
                    }
                }
                catch (FileNotFoundException ioEx)
                {
                    MessageBox.Show(ioEx.Message);
                }
            }
        }

        private void CompressButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream source = new FileStream(fileInfo.FullName, FileMode.Open))
                {
                    using (FileStream destination = File.Create(fileInfo.FullName.Replace(fileInfo.Extension, ".zip")))
                    {
                        using (GZipStream compressor = new GZipStream(destination, CompressionMode.Compress))
                        {
                            int @byte = source.ReadByte();
                            while (@byte != -1)
                            {
                                compressor.WriteByte((byte)@byte);
                                @byte = source.ReadByte();
                            }
                        }
                    }
                }

                MessageBox.Show($"File compressed successfuly.\nPath: {fileInfo.FullName.Replace(fileInfo.Extension, ".zip")}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }            
        }
    }
}
