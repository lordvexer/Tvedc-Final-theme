using System.Collections.Generic;
using System.Threading.Tasks;
using Tvedc.Dtos;
using Tvedc.Entities;

namespace Tvedc.Interfaces
{
    public interface ICensusService
    {
        Task<List<FileDto>> GetFilesAsync();
    }
}
