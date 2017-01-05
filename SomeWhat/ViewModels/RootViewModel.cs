using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace SomeWhat
{
	public class RootViewModel : ViewModelBase
	{
		public RootViewModel()
		{
			Wines = new ObservableCollection<WineItemViewItem> {
				new WineItemViewItem{Name = "Pinot Noir", Year = "2015", Image = "DefaultWine"},
				new WineItemViewItem{Name = "Pinot Noir", Year = "2014", Image = "DefaultWine"},
				new WineItemViewItem{Name = "Pinot Noir", Year = "2013", Image = "DefaultWine"},
				new WineItemViewItem{Name = "Pinot Noir", Year = "2012", Image = "DefaultWine"},
				new WineItemViewItem{Name = "Pinot Noir", Year = "2011", Image = "DefaultWine"},
				new WineItemViewItem{Name = "Pinot Noir", Year = "2010", Image = "DefaultWine"},
			};
		}

		public ObservableCollection<WineItemViewItem> Wines
		{
			get;
			set;
		}
	}

	public class WineItemViewItem : ViewModelBase
	{
		public string Name { get; set; }
		public string Year { get; set; }
		public string Image { get; set; }
	}
}
