using System.Windows;

namespace AudioEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
            
        }

        private void MakeRingtone_btn_Click(object sender, RoutedEventArgs e)
        {
            MakeRingtone mr = new MakeRingtone();
            mr.Show();
            Close();
        }

        private void btn_WorkWithTwoTracks_Click(object sender, RoutedEventArgs e)
        {
            TestWindow tw = new TestWindow();
            tw.Show();
            Close();
        }
    }
}
