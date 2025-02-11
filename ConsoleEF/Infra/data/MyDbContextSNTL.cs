using Microsoft.EntityFrameworkCore;
namespace ConsoleAppEF.Infra.Data;
 

public class MyDbContextSNTL : DbContext

{

    public DbSet<Client> Clients { get; set; }

    public DbSet<Convention> Conventions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    {

        optionsBuilder.UseSqlServer("Server=localhost;Database=DemoSNRT;User Id=sa;Password=Pass123@;");

    }

 

}
