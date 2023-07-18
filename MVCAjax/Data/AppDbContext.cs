using Microsoft.EntityFrameworkCore;
using MVCAjax.Data.Entities;

namespace MVCAjax.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FAFVSUB\\MSSQLSERVER01;Database=ETicaretDB;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }


}
