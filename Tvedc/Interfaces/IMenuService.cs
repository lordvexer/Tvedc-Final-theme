using System.Collections.Generic;
using System.Threading.Tasks;
using Tvedc.Entities;

namespace Tvedc.Interfaces
{
    public interface IMenuService
    {
        Task<List<Menu>> RootMainMenusAsync(int Level);
        Task<List<Menu>> MainMenusByParentIdAsync(int ParentId);
    }
}
