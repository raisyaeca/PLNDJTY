using DevExpress.Mobile.DataGrid;
using System;
using LoginNavigation.Pages;
using Xamarin.Forms;

namespace LoginNavigation
{

    public partial class MainPage : MasterDetailPage
	{
        public MainPage (string username)
		{
			InitializeComponent ();
            Appusername.Text = "Hello, " + username;
            IsPresented = false;
           
		}

        async void OnLogoutButtonClicked (object sender, EventArgs e)
		{
            App.IsUserLoggedIn = false;
			Navigation.InsertPageBefore (new LoginPage(), this);
            await Navigation.PopAsync ();
		}

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            
            await Navigation.PushAsync(new Home());
            IsPresented = false; 
        }

        async void Handle_Clicked3(object sender, System.EventArgs e)
        {
            
            await Navigation.PushAsync(new Rekap());
            IsPresented = false; 
        }

        async void Handle_Clicked4(object sender, System.EventArgs e)
        {
            
            await Navigation.PushAsync(new DeveloperProfile());
            IsPresented = false; 
        }

        async void Handle_Clicked2(object sender, System.EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new LoginPage(), this);
            await Navigation.PopAsync();
            IsPresented = false; 
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
