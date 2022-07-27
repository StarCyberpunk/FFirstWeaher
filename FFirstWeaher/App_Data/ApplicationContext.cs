using Microsoft.EntityFrameworkCore;

namespace FFirstWeaher.App_Data
{
    public class ApplicationContext:DbContext
    {
        public DbSet<FFirstWeaher.Models.Weather> Weathers { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder opBild)
        {
            opBild.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = Weatherdb; Initial Catalog = WeatherBD; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;");
        }
    }
}
