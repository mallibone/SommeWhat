using Xamarin.Forms;

namespace SomeWhat
{
	public partial class RootPage : ContentPage
	{
		public RootPage()
		{
			InitializeComponent();

			BindingContext = App.Locator.RootViewModel;
		}
	}
}
