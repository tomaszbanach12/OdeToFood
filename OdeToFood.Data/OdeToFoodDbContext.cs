using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public class OdeToFoodDbContext : DbContext
    {
        public OdeToFoodDbContext(DbContextOptions<OdeToFoodDbContext> options)
            : base(options)
        {
            // type in cmd: [C:\Projekty\OdeToFood\OdeToFood>dotnet ef dbcontext info -s OdeToFood.csproj]
            // type in cmd: [C:\Projekty\OdeToFood\OdeToFood>dotnet ef migrations add initialcreate -s OdeToFood.csproj]
        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
