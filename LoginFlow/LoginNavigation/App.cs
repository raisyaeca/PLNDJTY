using PushNotification.Plugin;
using Xamarin.Forms;

namespace LoginNavigation
{
	public class App : Application
	{
		public static bool IsUserLoggedIn { get; set; }

		public App ()
		{
			if (!IsUserLoggedIn) {
				MainPage = new NavigationPage (new SplashPage ());
			} else {
                MainPage = new NavigationPage(new LoginNavigaton.MainPage());

            }
            
        }
                
        public static void Mostrartoken(string token)
        {
            var main = Application.Current.MainPage as PushNotification;

            main.SetToken(token);
        }
        protected override void OnStart ()
		{
            CrossPushNotification.Current.Register();
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

