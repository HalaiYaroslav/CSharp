using AudioEditor.Classes.Observer;
using NAudio.Wave;

namespace AudioEditor.Classes
{
    class Reader : IObserver
    {
        private FileType fileType;
        private string fileName;

        public void Update(FileType fileType, string fileName)
        {
            this.fileType = fileType;
            this.fileName = fileName;
        }

        public WaveStream CreateReader()
        {
            WaveStream waveStream = null;

            switch(fileType)
            {
                case FileType.wav:
                    waveStream = new WaveFileReader(fileName);
                    break;
                case FileType.mp3:
                    waveStream = new Mp3FileReader(fileName);
                    break;
                case FileType.aiff:
                    waveStream = new AiffFileReader(fileName);
                    break;
                case FileType.wma:
                    waveStream = new MediaFoundationReader(fileName);
                    break;
            }
            return waveStream;
        }
    }
}
