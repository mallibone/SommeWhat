using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SommeWhat.Utils
{
    public static class Cloner
    {
        public static T Clone<T>(this T value)
        {
            // Uppercase the first letter in the string.
            var jsonValue = JsonConvert.SerializeObject(value);
            return JsonConvert.DeserializeObject<T>(jsonValue);
        }
    }
}
