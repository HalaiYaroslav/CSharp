using AudioEditor.Classes.Observer;

namespace AudioEditor.Classes
{
    class Writer : IObserver
    {
        private FileType fileType;
        private string createdFileName;

        public void Update(FileType fileType, string fileName)
        {
            this.fileType = fileType;
            
            createdFileName = fileName.Substring(0, fileName.Length - 4);

            createdFileName += $"(Resampled).{fileType}";
        }


    }
}
