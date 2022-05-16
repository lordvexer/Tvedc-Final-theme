using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Tvedc.Entities;

namespace Tvedc.Data
{
    public class TvedcContext : DbContext
    {
        public TvedcContext(DbContextOptions<TvedcContext> options) : base(options)
        {
        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Tender> Tenders { get; set; }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Tvedc.Entities.File> Files { get; set; }
        public DbSet<Tvedc.Entities.Category> Categories { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Permission>(opt =>
            {
                opt.Property(p=>p.FileId).IsRequired(); 
                opt.Property(p=>p.UserName).IsRequired(); 
                opt.Property(p=>p.Type).IsRequired(); 

                opt.HasKey(p=>new { p.FileId, p.UserName, p.Type });
                opt.HasIndex(p=>new { p.FileId, p.UserName, p.Type });
            });
        }
    }
}
