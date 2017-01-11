using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using SommeWhat.Services;

namespace SommeWhat.ViewModels
{
	internal class RootViewModel : ViewModelBase
	{
	    private readonly IWineService _wineService;

	    public RootViewModel(IWineService wineService)
	    {
	        if (wineService == null) throw new ArgumentNullException(nameof(wineService));
	        _wineService = wineService;
            Wines = new ObservableCollection<WineItemViewItem>();
	    }

		public ObservableCollection<WineItemViewItem> Wines
		{
			get;
		}

	    public async Task Initialise()
	    {
	        var wines = await _wineService.GetWines();

            Wines.Clear();

	        foreach (var wine in wines)
	        {
	            Wines.Add(new WineItemViewItem {Name = wine.Name, Image = wine.ImagePath, Year = wine.VintageYear});
	        }

	  //      Wines = new ObservableCollection<WineItemViewItem> {
			//	new WineItemViewItem{Name = "Pinot Noir", Year = "2015", Image = "DefaultWine"},
			//	new WineItemViewItem{Name = "Pinot Noir", Year = "2014", Image = "DefaultWine"},
			//	new WineItemViewItem{Name = "Pinot Noir", Year = "2013", Image = "DefaultWine"},
			//	new WineItemViewItem{Name = "Pinot Noir", Year = "2012", Image = "DefaultWine"},
			//	new WineItemViewItem{Name = "Pinot Noir", Year = "2011", Image = "DefaultWine"},
			//	new WineItemViewItem{Name = "Pinot Noir", Year = "2010", Image = "DefaultWine"},
			//};
	    }
	}

	public class WineItemViewItem : ViewModelBase
	{
		public string Name { get; set; }
		public string Year { get; set; }
		public string Image { get; set; }
	}
}
