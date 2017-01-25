using System.Threading.Tasks;
using SommeWhat.ViewModels;
using Xamarin.Forms;

namespace SommeWhat.Views
{
	public partial class RootPage : ContentPage
	{
		public RootPage()
		{
			InitializeComponent();

		    BindingContext = viewModel;
		}

        private RootViewModel viewModel => App.Locator.RootViewModel;

	    protected override async void OnAppearing()
	    {
	        base.OnAppearing();
	        await viewModel.Initialise();
	    }
	}
}
