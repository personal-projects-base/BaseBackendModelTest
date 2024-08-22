using Base_Backend.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Base_Backend.Config.Database
{
    public class ApiDbContext : DbContext
    {
        private string Schema;
        public ApiDbContext(){}

        
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
            Schema = "";
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema($"public{Schema}");
        }
        
        public DbSet<ProductEntity> ProductContext { get; set; }
    }
}
