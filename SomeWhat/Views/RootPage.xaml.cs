using Xamarin.Forms;

namespace SommeWhat.Views
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
