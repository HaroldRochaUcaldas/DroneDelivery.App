using Microsoft.EntityFrameworkCore;
using DroneDelivery.App.Dominio;

namespace DroneDelivery.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDb; Initial Catalog = DroneDelivery.dat");
        }
    }
    }
}