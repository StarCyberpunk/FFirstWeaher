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
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        protected override void OnConfiguring(DbContextOptionsBuilder opBild)
        {
            opBild.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = Weatherdb; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;");
        }
    }
}
