using NAudio.Wave;
using System.Windows;
using NAudio.CoreAudioApi;
using AudioEditor.Classes.Observer;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using System.Windows.Shapes;

namespace AudioEditor.Classes
{
    class AudioTrack : IObservable
    {
        #region Singleton        
        private static AudioTrack audioTrack;

        protected AudioTrack()
        {
            
        }

        public static AudioTrack Instance()
        {
            if (audioTrack == null)
            {
                audioTrack = new AudioTrack();
            }
            return audioTrack;
        }
        #endregion

        #region Observer
        List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(audioFileType, audioFileName);
            }
        }
        #endregion        

        private string audioFileName;
        public string AudioFileName
        {
            get { return audioFileName; }
            set
            {
                if (value != string.Empty)
                {
                    audioFileName = value;
                    AudioFileType = GetFileType(value);
                }
            }
        }

        private WasapiOut wasapiOut;
        public WasapiOut WasapiOut
        {
            get { return wasapiOut; }
            set
            {
                if (wasapiOut == null) wasapiOut = value;
                else
                {
                    MessageBox.Show($"Object of WasapiOut: {wasapiOut.GetHashCode()}\nwas disposed.");
                    wasapiOut.Dispose();
                    wasapiOut = value;
                }
            }
        }

        private Reader fileReader;
        public Reader FileReader
        {
            get { return fileReader; }
            set { fileReader = value; }
        }

        private Writer fileWriter;
        public Writer FileWriter
        {
            get { return fileWriter; }
            set { fileWriter = value; }
        }
                
        private WaveStream reader;
        public WaveStream Reader
        {
            get { return reader; }
            set
            {
                if (reader == null) reader = value;
                else
                {
                    MessageBox.Show($"Object of Mp3FileReader: {reader.GetHashCode()}\nwas disposed.");
                    reader.Dispose();
                    reader = value;
                }
            }
        }

        private VolumeWaveProvider16 volumeProvider;
        public VolumeWaveProvider16 VolumeProvider
        {
            get { return volumeProvider; }
            set
            {
                volumeProvider = value;
            }
        }

        private MMDeviceCollection deviceCollection;
        public MMDeviceCollection DeviceCollection
        {
            get { return deviceCollection; }
            set
            {
                deviceCollection = value;
            }
        }

        private FileType audioFileType;
        public FileType AudioFileType
        {
            get { return audioFileType; }
            private set { audioFileType = value; }
        }

        private FileType GetFileType(string fileName)
        {
            switch (System.IO.Path.GetExtension(fileName))
            {
                case ".wav":
                    return FileType.wav;
                case ".mp3":
                    return FileType.mp3;
                case ".aiff":
                    return FileType.aiff;
                case ".wma":
                    return FileType.wma;
                default:
                    return FileType.wav;
            }
        }

        public void ConfigurePlayback()
        {
            var deviceEnumerator = new MMDeviceEnumerator();
            deviceCollection = deviceEnumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);

            var device = deviceCollection[0];
            AudioClientShareMode shareMode = AudioClientShareMode.Shared;
            int latency = 20;
            bool useEventSync = false;
            wasapiOut = new WasapiOut(device, shareMode, useEventSync, latency);
                        
            reader = fileReader.CreateReader();

            volumeProvider = new VolumeWaveProvider16(reader);

            wasapiOut.Init(volumeProvider); 
        }

        public Polyline MakeWaveFrom()
        {            
            int xPos = 2;
            var yScale = 50;
            var topPoints = new List<Point>();
            var bottomPoints = new List<Point>();
            using (var reader = new AudioFileReader(audioFileName))
            {
                var samplesPerSecond = (reader.WaveFormat.SampleRate *
                            reader.WaveFormat.Channels) / 4;
                var readBuffer = new float[samplesPerSecond];

                int samplesRead;
                do
                {
                    samplesRead = reader.Read(readBuffer, 0, samplesPerSecond);
                    if (samplesRead > 0)
                    {
                        var max = readBuffer.Take(samplesRead).Max();
                        topPoints.Add(new Point(xPos, yScale + max * yScale));
                        bottomPoints.Add(new Point(xPos, yScale - max * yScale));
                        xPos += 2;
                    }
                } while (samplesRead > 0);

                var polyline = new Polyline();
                polyline.Points.Add(new Point(0, yScale));
                foreach (var p in topPoints)
                {
                    polyline.Points.Add(p);
                }

                polyline.Points.Add(new Point(xPos, yScale));
                bottomPoints.Reverse();
                foreach (var p in bottomPoints)
                {
                    polyline.Points.Add(p);
                }
                polyline.Points.Add(new Point(0, yScale));

                polyline.Fill = Brushes.OrangeRed;
                polyline.Stroke = Brushes.BlueViolet;
                polyline.StrokeThickness = 1.0;                

                return polyline;
            }
        }        
    }
}
