using KhoaLuanTotNghiep_BackEnd.Data.SeedData;
using KhoaLuanTotNghiep_BackEnd.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KhoaLuanTotNghiep.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedRealEstateData();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Category> categories { get; set; }

        public DbSet<RealEstate> realEstates { get; set; }

        public DbSet<Report> reports { get; set; }

        public DbSet<News> news { get; set; }

        public DbSet<Rates> rates { get; set; }

        public DbSet<Transaction> transactions { get; set; }


    }
}
