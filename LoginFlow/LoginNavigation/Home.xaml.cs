using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoginNavigation
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();            
        }

        public async void CameraButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Page1());
        }

        public async void TagButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Page2());
        }

        public async void ProfilePLNButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Pagetiga());
        }

        public async void PedomanPerilakuButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PedomanPerilaku());
        }
       
        public async void GCGButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new GCG());
        }

        public async void WhistleblowerButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Whistleblower());
        }

        public void ShoppingButtonTapped(object sender, EventArgs args)
        {
            throw new NotImplementedException();
        }

        public void TwitterButtonTapped(object sender, EventArgs args)
        {
            throw new NotImplementedException();
        }


    }
}

