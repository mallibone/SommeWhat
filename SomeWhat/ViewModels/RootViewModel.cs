using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
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
            AddWine = new RelayCommand(AddWineSelected);
        }

        public ObservableCollection<WineItemViewItem> Wines
        {
            get;
        }

        public RelayCommand AddWine { get; }

        public async Task Initialise()
        {
            var wines = await _wineService.GetWines();

            Wines.Clear();

            foreach (var wine in wines)
            {
                Wines.Add(new WineItemViewItem { Name = wine.Name, Image = wine.ImagePath, Year = wine.VintageYear });
            }
        }

        private void AddWineSelected()
        {
            throw new NotImplementedException();
        }
    }
}
