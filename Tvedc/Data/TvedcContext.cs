using Microsoft.EntityFrameworkCore;
using Tvedc.Entities;

namespace Tvedc.Data
{
    public class TvedcContext : DbContext
    {
        public TvedcContext(DbContextOptions<TvedcContext> options) : base(options)
        {
        }

        public DbSet<Menu> Menus { get; set; }
    }
}
