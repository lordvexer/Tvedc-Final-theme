using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tvedc.Data;
using Tvedc.Dtos;
using Tvedc.Interfaces;

namespace Tvedc.Services
{
    public class CensusService : ICensusService
    {
        private readonly TvedcContext _context;
        private readonly IMapper _mapper;

        public CensusService(TvedcContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<List<FileDto>> GetFilesAsync()
        {
            var query = from fi in _context.Files.Where(ff => ff.IsDelete == false)
                        from c in _context.Categories.Where(cc => cc.CategoryID == fi.TypeID && cc.GroupID == 3)
                        from per in _context.Permissions.Where(pp => pp.FileId == fi.ID && pp.Type == "file" && pp.UserName == "anonymous")
                        select fi;
            var files = await query
                 .OrderByDescending(p => p.ID)
                 .ToListAsync();

            return _mapper.Map<List<Entities.File>, List<Dtos.FileDto>>(files);
        }
    }
}
