using Base_Backend.Gen;
using Base_Backend.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Base_Backend.Config.Database
{
    public class ApiDbContext : CustomDbContext
    {

        public ApiDbContext(){}
        
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }
    }
}
