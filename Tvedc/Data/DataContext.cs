using Microsoft.EntityFrameworkCore;
using Tvedc.Entities;

namespace Tvedc.Data    
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        public DbSet<News> News { get; set; }
        public DbSet<NewsForArchive> NewsForArchives { get; set; }
    }
}
