using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tvedc.Data;
using Tvedc.Entities;
using Tvedc.Interfaces;

namespace Tvedc.Services
{
    public class MenuService : IMenuService
    {
        private readonly TvedcContext _context;

        public MenuService(TvedcContext context)
        {
            this._context = context;
        }
        public async Task<List<Menu>> RootMainMenusAsync(int Level)
        {
            return await _context.Menus
                .Where(p => p.Level == Level && !p.ParentId.HasValue && p.Visible && p.IsMainMenu.HasValue && p.IsMainMenu.Value)
                .ToListAsync();

        }

        public async Task<List<Menu>> MainMenusByParentIdAsync(int ParentId)
        {
            return await _context.Menus
                .Where(p => p.ParentId.HasValue && p.ParentId == ParentId && p.Visible && p.IsMainMenu.HasValue && p.IsMainMenu.Value)
                .ToListAsync();
        }
    }
}
