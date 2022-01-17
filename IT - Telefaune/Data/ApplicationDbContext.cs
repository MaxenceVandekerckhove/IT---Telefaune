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

        public DbSet<SiteModel> Site { get; set; }
        public DbSet<ServiceModel> Service { get; set; }
        public DbSet<AdminModel> Admin { get; set; }
        public DbSet<SalarieModel> Salarie { get; set; }
    }
}
