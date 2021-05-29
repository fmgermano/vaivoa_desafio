using Microsoft.EntityFrameworkCore;
using vvef.Domain.Models;
using vvef.Data.Configurations;


namespace vvef.Domain.Persistence.Contexts
{
    public class DataContext : DbContext
    {

      public DbSet<Cliente> Clientes {get; set;}
      public DbSet<Card> Cards {get; set;}
        public DataContext(DbContextOptions<DataContext> options)
          :base(options)
    { }

    protected override void OnModelCreating(ModelBuilder builder)

    { 
      

            builder
            .ApplyConfiguration(new CardConfiguration());
            
            builder
            .ApplyConfiguration(new ClienteConfiguration());

            
        }
    }
}