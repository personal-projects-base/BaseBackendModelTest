using Base_Backend.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Base_Backend.Gen;

public abstract class CustomDbContext : DbContext
{
    public string Schema = "public";
    
    public static readonly AsyncLocal<string> _asyncThread = new();
    
    public CustomDbContext(){}
    
    public CustomDbContext(DbContextOptions options) : base(options)
    {

    }
    
    public CustomDbContext(DbContextOptions options, String _schema = "") : base(options)
    {
        Schema = _schema;
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasDefaultSchema($"{_asyncThread.Value}");
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured) {}
        optionsBuilder.ReplaceService<IModelCacheKeyFactory, DynamicSchemaModelCacheKeyFactory>();
    }
        
    public DbSet<ProductEntity> ProductContext { get; set; }
    public DbSet<PaisEntity> PaisContext { get; set; }
    public DbSet<EstadoEntity> EstadoContext { get; set; }
    public DbSet<CidadeEntity> CidadeContext { get; set; }
}