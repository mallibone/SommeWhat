using SommeWhat.Views;
using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace SommeWhat
{
	public partial class App : Application
	{
		private static ViewModelLocator _locator;

		internal static ViewModelLocator Locator
		{
			get
			{
				return _locator ?? (_locator = new ViewModelLocator());
			}
		}

		public App()
		{
            MobileCenter.Start(typeof(Analytics), typeof(Crashes));

            InitializeComponent();

			MainPage = new NavigationPage(new RootPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
