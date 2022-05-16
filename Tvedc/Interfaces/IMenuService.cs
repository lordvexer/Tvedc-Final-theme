using System.Collections.Generic;
using System.Threading.Tasks;
using Tvedc.Dtos;

namespace Tvedc.Interfaces
{
    public interface IMenuService
    {
        Task<List<MenuDto>> RootMainMenusAsync(int Level);
        Task<List<MenuDto>> MainMenusByParentIdAsync(int ParentId);
    }
}
