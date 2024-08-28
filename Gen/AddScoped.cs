using Base_Backend.Repository;

namespace Base_Backend.Gen
{
    public class AddScoped
    {
        public static void AddScopedGenerate(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IEstadoRepository, EstadoRepository>();
            builder.Services.AddScoped<IPaisRepository, PaisRepository>();
            builder.Services.AddScoped<ICidadeRepository, CidadeRepository>();
        }
    }
}

