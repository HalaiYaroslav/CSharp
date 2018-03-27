namespace AudioEditor.Classes.Observer
{
    interface IObserver
    {
        void Update(FileType fileType, string fileName);
    }
}
