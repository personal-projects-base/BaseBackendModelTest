using Base_Backend.Config;
using Base_Backend.Config.Database;
using Base_Backend.Config.Scoped;
using Base_Backend.Gen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApiDbContext>(item =>
{
    item.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
    
});
builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

AddScoped.AddScopedGenerate(builder);
ConfigScoped.AddSecurity(builder);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowOrigin");


app.UseAuthorization();
app.UseMiddleware<BaseMiddleware>();
app.MapControllers();

app.Run();
