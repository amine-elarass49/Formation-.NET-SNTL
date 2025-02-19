// See https://aka.ms/new-console-template for more information
using ConsoleAppDBFirst.Entities;
using ConsoleAppDBFirst.Infra;



var dbContext = new FormationOumdinAcademyContext();
var client1 = new TClient(){
    Id= 2 , Adresse = "address sale", Client= "EL ARASS Amine"
};
dbContext.TClients. Add(client1);
dbContext.SaveChanges();

/* ToList() vs sans TOList() 
 ToList() : lors using Where or OrderBY , s'execute au niveau de code
 par contre : l'autre s'execute au niveau de la base de données
*/
dbContext.TClients.ToList().ForEach(c=>Console.WriteLine($"id {c.Id} , address: {c.Adresse}, Client: {c.Client}"));
