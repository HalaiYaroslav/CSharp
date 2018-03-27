namespace AudioEditor.Classes.Composite
{
    interface IEnableable
    {
        void EnableControl();
        void DisableControl();

        void CreateChildControl(IEnableable control);
        void DeleteChildControl(IEnableable control);
    }
}
