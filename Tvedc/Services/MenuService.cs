using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tvedc.Data;
using Tvedc.Dtos;
using Tvedc.Entities;
using Tvedc.Interfaces;

namespace Tvedc.Services
{
    public class MenuService : IMenuService
    {
        private readonly TvedcContext _context;
        private readonly IMapper _mapper;

        public MenuService(TvedcContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
        public async Task<List<MenuDto>> RootMainMenusAsync(int Level)
        {
            var menus = await _context.Menus
                .Where(p => p.Level == Level && !p.ParentId.HasValue && p.Visible && p.IsMainMenu.HasValue && p.IsMainMenu.Value)
                .OrderBy(p=> p.DisplayOrder)
                .ToListAsync();

            return _mapper.Map<List<MenuDto>>(menus); 
        }

        public async Task<List<MenuDto>> MainMenusByParentIdAsync(int ParentId)
        {
            var menus = await _context.Menus
                .Where(p => p.ParentId.HasValue && p.ParentId == ParentId && p.Visible && p.IsMainMenu.HasValue && p.IsMainMenu.Value)
                .OrderBy(p=> p.DisplayOrder)
                .ToListAsync();

            return _mapper.Map<List<MenuDto>>(menus);
        }
    }
}
