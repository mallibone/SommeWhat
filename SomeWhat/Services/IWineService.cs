using System.Collections.Generic;
using System.Threading.Tasks;
using SommeWhat.Models;

namespace SommeWhat.Services
{
    internal interface IWineService
    {
        Task<IEnumerable<Wine>> GetWines();
    }
}