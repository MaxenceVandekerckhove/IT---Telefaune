using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT___Telefaune.Models.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SiteModel>()
                .HasOne<ServiceModel>(s => s.TypeService)
                .WithMany(g => g.Site);

            modelBuilder.Entity<SalarieModel>()
                .HasOne<ServiceModel>(t => t.TypeService)
                .WithMany(g => g.Salarie);

            modelBuilder.Entity<SalarieModel>()
                .HasOne<SiteModel>(u => u.NomSite)
                .WithMany(g => g.Salarie);
        }

        public DbSet<SiteModel> Site { get; set; }
        public DbSet<ServiceModel> Service { get; set; }
        public DbSet<AdminModel> Admin { get; set; }
        public DbSet<SalarieModel> Salarie { get; set; }

    }

}
