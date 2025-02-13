using ConsoleAppEF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ConsoleAppEF.Infra.Data;
 

public class MyDbContextSNTL : DbContext

{

    #region "DbSet"
    public DbSet<Client> Clients { get; set; }
    public DbSet<Convention> Conventions { get; set; }

    #endregion

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
                .Build();

      //  var constr = configuration.GetSection("ConnectionStrings:ZoneToLearnDb").Value;
        var constr = configuration.GetConnectionString("ZoneToLearnDb");



        optionsBuilder.UseSqlServer(constr);
    }

    //Create OnModelCreating method
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

      /*  modelBuilder.Entity<Client>()
            .Property(p => p.ImagePath)
            .HasDefaultValue("images/default.jpg"); 
            */
    }
 

}
