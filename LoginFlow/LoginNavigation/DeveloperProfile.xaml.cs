using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoginNavigation
{
    public partial class DeveloperProfile : ContentPage
    {
        public DeveloperProfile()
        {
            InitializeComponent();
        }

        public async void NajaButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new naja());
        }

        public async void SendyButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new sendy());
        }

        public async void VinaButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new vina());
        }

        public async void EcaButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new eca());
        }
    }
}

