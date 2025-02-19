// See https://aka.ms/new-console-template for more information
// ce projet dedie l'externalisation du connectionString 
using ConsoleAppDBFirst2.Entities;
using ConsoleAppDBFirst2.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

// Load configuration from appsettings.json
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

// Get the connection string
var connectionString = configuration.GetConnectionString("DefaultConnection");

// Configure the DbContext
var optionsBuilder = new DbContextOptionsBuilder<FormationOumdinAcademyContext>();
optionsBuilder.UseSqlServer(connectionString);

// Create the DbContext instance
using (var dbContext = new FormationOumdinAcademyContext(optionsBuilder.Options))
{
for (int i = 3; i <= 10; i++)
{
    var client1 = new TClient { Id = i, Client = $"Client {i}", Adresse = $"Adresse Client  {i}" };
    dbContext.TClients.Add(client1);
    dbContext.SaveChanges();

}


dbContext.TClients.ToList().ForEach(c=>Console.WriteLine($"id {c.Id} , address: {c.Adresse}, Client: {c.Client}"));

    
}