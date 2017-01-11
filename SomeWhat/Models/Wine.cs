using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SommeWhat.Models
{
    class Wine
    {
		public string Name { get; set; }
		public DateTime Vintage { get; set; }
		public string ImagePath { get; set; }
        [JsonIgnore]
        public string VintageYear => Vintage.Year.ToString();
    }
}
