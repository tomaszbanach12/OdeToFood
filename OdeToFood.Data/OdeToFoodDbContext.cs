using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public class OdeToFoodDbContext : DbContext
    {
        public OdeToFoodDbContext(DbContextOptions<OdeToFoodDbContext> options)
            : base(options)
        {
            // only once
            // PS C:\Projekty\OdeToFood\OdeToFood.Data> dotnet ef dbcontext info -s ..\OdeToFood\OdeToFood.csproj
            // PS C:\Projekty\OdeToFood\OdeToFood.Data> dotnet ef migrations add initialcreate -s ..\OdeToFood\OdeToFood.csproj
            // if i add another properties to class Restaurant etc, i need migrate database schema
            //PS C:\Projekty\OdeToFood\OdeToFood.Data > dotnet ef database update - s..\OdeToFood\OdeToFood.csproj

            // type in cmd: [C:\Projekty\OdeToFood\OdeToFood>dotnet ef dbcontext info -s OdeToFood.csproj]
            // type in cmd: [C:\Projekty\OdeToFood\OdeToFood>dotnet ef migrations add initialcreate -s OdeToFood.csproj]
        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
