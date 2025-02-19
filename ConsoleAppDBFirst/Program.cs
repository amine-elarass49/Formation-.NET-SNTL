// See https://aka.ms/new-console-template for more information
using ConsoleAppDBFirst.Entities;
using ConsoleAppDBFirst.Infra;



var dbContext = new FormationOumdinAcademyContext();
var client1 = new TClient(){
    Id= 2 , Adresse = "address sale", Client= "EL ARASS Amine"
};
dbContext.TClients. Add(client1);
dbContext.SaveChanges();

foreach(var client in dbContext.TClients.ToList().OrderBy(c=> c.Client)){
    Console.WriteLine($"id {client.Id} , address: {client.Adresse}, Client: {client.Client}");
}


