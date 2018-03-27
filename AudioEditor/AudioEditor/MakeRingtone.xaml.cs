using System;
using System.Windows;
using NAudio.Wave;
using System.Windows.Threading;
using System.Windows.Forms;
using AudioEditor.Classes;
using AudioEditor.Classes.WaveFormVisualizing;
using System.Threading;
using AudioEditor.Classes.Composite;

namespace AudioEditor
{
    /// <summary>
    /// Interaction logic for MakeRingtone.xaml
    /// </summary>
    ///     
    public partial class MakeRingtone : Window
    {
        public MakeRingtone()
        {
            InitializeComponent();
            ConfigureTimer();

            waveFormRenderer = new WaveFormRenderer();

            #region Composite realization  
            UserButton userSaveBtn = new UserButton(SaveBtn);
            UserButton userPlayBtn = new UserButton(PlayBtn);
            UserButton userPauseBtn = new UserButton(PauseBtn);
            UserButton userRepeatBtn = new UserButton(RepeatBtn);
                        
            ControlsContainer buttonsContainer = new ControlsContainer();
            buttonsContainer.CreateChildControl(userSaveBtn);
            buttonsContainer.CreateChildControl(userPlayBtn);
            buttonsContainer.CreateChildControl(userPauseBtn);
            buttonsContainer.CreateChildControl(userRepeatBtn);

            UserSlider userRangeSlider = new UserSlider(RangeSlider);
            UserSlider userVolumeSlider = new UserSlider(VolumeSlider);

            ControlsContainer slidersContainer = new ControlsContainer();
            slidersContainer.CreateChildControl(userRangeSlider);
            slidersContainer.CreateChildControl(userVolumeSlider);

            rootControlsContainer.CreateChildControl(buttonsContainer);
            rootControlsContainer.CreateChildControl(slidersContainer);

            #endregion

            rootControlsContainer.DisableControl();
        }

        private ControlsContainer rootControlsContainer = new ControlsContainer();

        private WaveFormRenderer waveFormRenderer;

        private DispatcherTimer timer;
        private AudioTrack audioTrack = AudioTrack.Instance();

        private void ConfigureTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += TimerTick;
        }

        private void ConfigureControls()
        {
            DurationTxtBlock.Text = $"{audioTrack.Reader.TotalTime.Minutes} minutes {audioTrack.Reader.TotalTime.Seconds} seconds";
            PositionTxtBlock.Text = $"{audioTrack.Reader.CurrentTime.Minutes} minutes {audioTrack.Reader.CurrentTime.Seconds} seconds";

            RangeSlider.Maximum = audioTrack.Reader.TotalTime.TotalSeconds;
            RangeSlider.UpperValue = audioTrack.Reader.TotalTime.TotalSeconds;

            VolumeSlider.Value = 0;

            audioTrack.VolumeProvider.Volume = (float)VolumeSlider.Value;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (audioTrack.Reader != null)
            {
                PositionTxtBlock.Text = $"{audioTrack.Reader.CurrentTime.Minutes} minutes {audioTrack.Reader.CurrentTime.Seconds} seconds";
                RangeSlider.LowerValue = audioTrack.Reader.CurrentTime.TotalSeconds;
            }
        }

        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Audio Files(*.wav, *.mp3, *.aiff, *.wma)|*.mp3;*.wav;*.aiff;*.wma";

            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

            audioTrack.AudioFileName = fileDialog.FileName;

            RenderWaveform();

            #region Observer Realisation            
            Reader fileReader = new Reader();
            Writer fileWriter = new Writer();

            audioTrack.FileReader = fileReader;
            audioTrack.FileWriter = fileWriter;

            audioTrack.AddObserver(fileReader);
            audioTrack.AddObserver(fileWriter);

            audioTrack.NotifyObservers();
            #endregion

            audioTrack.ConfigurePlayback();
            audioTrack.WasapiOut.PlaybackStopped += WaveOutPlaybackStopped;

            //enabling all controls after the audio track loaded.
            rootControlsContainer.EnableControl();

            ConfigureControls();
        }

        private void PlayBtn_Click(object sender, RoutedEventArgs e)
        {
            if (audioTrack.WasapiOut != null && (audioTrack.WasapiOut.PlaybackState == PlaybackState.Paused || audioTrack.WasapiOut.PlaybackState == PlaybackState.Stopped))
            {
                timer.Start();

                audioTrack.WasapiOut.Play();
            }
        }

        private void WaveOutPlaybackStopped(object sender, StoppedEventArgs e)
        {
            RangeSlider.LowerValue = 0;
            timer.Stop();
            //audioTrack.Reader.Dispose();
            //audioTrack.WasapiOut.Dispose();            
            if (e.Exception != null)
            {
                System.Windows.MessageBox.Show(e.Exception.Message);
            }
        }

        private void PauseBtn_Click(object sender, RoutedEventArgs e)
        {
            if (audioTrack.WasapiOut != null && audioTrack.WasapiOut.PlaybackState == PlaybackState.Playing)
            {
                audioTrack.WasapiOut.Pause();
                timer.Stop();
            }
        }

        private void RepeatBtn_Click(object sender, RoutedEventArgs e)
        {
            if (audioTrack.WasapiOut != null)
            {
                audioTrack.Reader.Position = 0;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (audioTrack.Reader != null && audioTrack.WasapiOut != null)
            {
                audioTrack.Reader.Dispose();
                audioTrack.WasapiOut.Dispose();
                timer.Stop();
            }
        }

        private void Savebtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VolumeTxtBlock.Text = $"Volume: {(int)(VolumeSlider.Value / 0.2 * 100)}%";
            if (audioTrack.WasapiOut != null)
            {
                audioTrack.VolumeProvider.Volume = (float)VolumeSlider.Value;
            }
        }

        private void BackToMainManu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        #region Waveform visualizing methods        
        private IPeakProvider GetPeakProvider()
        {

            return new SamplingPeakProvider(500);
        }

        private void RenderWaveform()
        {
            if (audioTrack.AudioFileName == null) return;
            waveFormRenderer.TopHeight = 100; //height of top
            waveFormRenderer.BottomHeight = 50; //height og dowm
            waveFormRenderer.Width = 1100;//width
            waveFormRenderer.BackgroundColor = System.Drawing.Color.WhiteSmoke;//background color
            waveFormRenderer.TopWaveformPen = new System.Drawing.Pen(System.Drawing.Color.Red); //top wave color
            waveFormRenderer.BottomWaveformPen = new System.Drawing.Pen(System.Drawing.Color.OrangeRed); //bottom wave color
            waveFormRenderer.DecibelScale = false;
            PictureBoxWaveHolder.Image = null;
            var peakProvider = GetPeakProvider();
            ThreadPool.QueueUserWorkItem(RenderThreadFunc, peakProvider);
        }

        private void RenderThreadFunc(object peakProvider)
        {
            System.Drawing.Image image = null;
            try
            {
                image = waveFormRenderer.Render(audioTrack.AudioFileName, (IPeakProvider)peakProvider);
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
            FinishedRender(image);
        }

        private void FinishedRender(System.Drawing.Image image)
        {
            PictureBoxWaveHolder.Image = image;
        }
        #endregion

        private void RangeSlider_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            if (audioTrack.Reader != null)
            {
                audioTrack.Reader.CurrentTime = TimeSpan.FromSeconds(RangeSlider.LowerValue);
            }
        }
    }
}
