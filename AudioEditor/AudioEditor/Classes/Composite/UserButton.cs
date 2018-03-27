using System;
using System.Windows.Controls;

namespace AudioEditor.Classes.Composite
{
    class UserButton : IEnableable
    {
        private Button buttonForEnabling;

        public UserButton(Button button)
        {
            buttonForEnabling = button;
        }

        public void CreateChildControl(IEnableable control)
        {
            throw new NotImplementedException("Adding Child Control to Button is not possible");
        }

        public void DeleteChildControl(IEnableable control)
        {
            throw new NotImplementedException("Removing Child Control from Button is not possible");
        }

        public void DisableControl()
        {
            buttonForEnabling.IsEnabled = false;
        }

        public void EnableControl()
        {
            buttonForEnabling.IsEnabled = true;
        }
    }
}
