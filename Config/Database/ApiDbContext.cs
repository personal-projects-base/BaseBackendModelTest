using Base_Backend.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Base_Backend.Config.Database
{
    public class ApiDbContext : IdentityDbContext
    {
        
        public ApiDbContext(){}

        private string Schema;
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
