using System;
using System.Windows.Controls;

namespace AudioEditor.Classes.Composite
{
    class UserSlider : IEnableable
    {
        private Control sliderForEnabling;

        public UserSlider(Control slider)
        {
            sliderForEnabling = slider;
        }

        public void CreateChildControl(IEnableable control)
        {
            throw new NotImplementedException("Adding Child Control to Slider is not possible");
        }

        public void DeleteChildControl(IEnableable control)
        {
            throw new NotImplementedException("Removing Child Control from Slider is not possible");
        }

        public void DisableControl()
        {
            sliderForEnabling.IsEnabled = false;
        }

        public void EnableControl()
        {
            sliderForEnabling.IsEnabled = true;
        }
    }
}
