
using System.Collections.Generic;


namespace AudioEditor.Classes.Composite
{
    class ControlsContainer : IEnableable
    {
        List<IEnableable> ChildControls = new List<IEnableable>();        

        public void CreateChildControl(IEnableable control)
        {
            ChildControls.Add(control as IEnableable);
        }

        public void DeleteChildControl(IEnableable control)
        {
            ChildControls.Remove(control as IEnableable);
        }

        public void DisableControl()
        {
            foreach (IEnableable childControl in ChildControls)
            {                
                childControl.DisableControl();
            }
        }

        public void EnableControl()
        {
            foreach (IEnableable childControl in ChildControls)
            {
                childControl.EnableControl();
            }
        }
    }
}
