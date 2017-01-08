using Android.App;
using Android.Content.PM;
using Android.OS;
using Microsoft.Azure.Mobile;

namespace SommeWhat.Droid
{
	[Activity(Label = "SommeWhat", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

            MobileCenter.Configure("a593f4e7-5eca-4d24-ae4e-40ad4b5704de");

            LoadApplication(new App());
		}
	}
}
