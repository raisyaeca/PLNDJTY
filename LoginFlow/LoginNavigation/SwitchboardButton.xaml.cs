using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace LoginNavigation
{
    public partial class SwitchboardButton : ContentView
    {
        public SwitchboardButton()
        {
            InitializeComponent();
        }

        public ImageSource Icon
        {
            get { return SwitchboardIcon.Source; }
            set { SwitchboardIcon.Source = value; }
        }

        public string Label
        {
            get { return SwitchboardLabel.Text; }
            set { SwitchboardLabel.Text = value; }
        }
    }
}
