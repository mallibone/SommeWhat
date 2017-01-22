using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SommeWhat.Models;
using SommeWhat.Utils;
using SommeWhat.ViewModels;

namespace SommeWhat.Services
{
    internal class StubWineService : IWineService
    {
        private List<Wine> _wines;

        public StubWineService()
        {
			_wines = new List<Wine> {
				new Wine{Name = "Pinot Noir", Vintage = new DateTime(2015), ImagePath = "DefaultWine"},
				new Wine{Name = "Pinot Noir", Vintage = new DateTime(2014), ImagePath = "DefaultWine"},
				new Wine{Name = "Pinot Noir", Vintage = new DateTime(2013), ImagePath = "DefaultWine"},
				new Wine{Name = "Pinot Noir", Vintage = new DateTime(2012), ImagePath = "DefaultWine"},
				new Wine{Name = "Pinot Noir", Vintage = new DateTime(2011), ImagePath = "DefaultWine"},
				new Wine{Name = "Pinot Noir", Vintage = new DateTime(2010), ImagePath = "DefaultWine"},
			};
        }

        public Task<IEnumerable<Wine>> GetWines()
        {
            return Task.FromResult(_wines.Clone<IEnumerable<Wine>>());
        }
    }
}
