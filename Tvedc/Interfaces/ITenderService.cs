using System.Collections.Generic;
using System.Threading.Tasks;
using Tvedc.Dtos;

namespace Tvedc.Interfaces
{
    public interface ITenderService
    {
        Task<List<TenderDto>> GetLastTenders();
    }
}
