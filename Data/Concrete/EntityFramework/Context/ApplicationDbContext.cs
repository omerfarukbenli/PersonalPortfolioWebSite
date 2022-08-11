using Microsoft.EntityFrameworkCore;
using PersonalPortfolioWebSite.Data.Configuration;
using PersonalPortfolioWebSite.Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolioWebSite.Data.Concrete.EntityFramework.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //       base.OnConfiguring(optionsBuilder);
        //      optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Personalpo;Trusted_Connection=True;");
        //}
        public DbSet<Repo> Repo { get; set; }
        public DbSet<Home> Home { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Link> Link { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RepoConfiguration());
            builder.ApplyConfiguration(new HomeConfiguration());
            builder.ApplyConfiguration(new ContactConfiguration());
            builder.ApplyConfiguration(new AboutConfiguration());
            builder.ApplyConfiguration(new LinkConfiguration());
        }
    }
}
