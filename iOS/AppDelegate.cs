using Foundation;
using Microsoft.Azure.Mobile;
using UIKit;

namespace SommeWhat.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			// Code for starting up the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
#endif

            MobileCenter.Configure("f3e76c59-8869-4e92-b07b-4a72450dbd2f");

            LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
