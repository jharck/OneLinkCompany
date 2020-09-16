using OneLinkCompany.Models;
using Microsoft.EntityFrameworkCore;

namespace OneLinkCompany.Data
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {
        }

        public DbSet<Subarea> Subareas { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subarea>().ToTable("Subarea");
            modelBuilder.Entity<Area>().ToTable("Area");
            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
    }
}