// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using ConsoleAppEF.Entities;
using ConsoleAppEF.Infra.Data;
using Microsoft.Extensions.Logging;

// Add a Console Trace Listener manually
/* Trace.Listeners.Add(new ConsoleTraceListener());
Console.WriteLine("Hello, World!");
Trace.WriteLine("This is a trace message when tracing the app.");
Debug.WriteLine("This is a debug message just for developers.");*/

// CodeFirst Formation SNTL

//La création
/*
using (var context = new MyDbContextSNTL())
{

    Client client = new Client
    {
        Nom = "EL KHALDI ASA",
        Address= "Address SSS",
        Email = "SSSS@gmail.ma",
        Phone = "0588999962"
    };
    context.Clients.Add(client);
    context.SaveChanges();
    Console.WriteLine("Client ajouté avec succès !");
}



//Pour voire la liste des catégories
using (var context = new MyDbContextSNTL())
{
    var list = context.Clients.ToList();

    list.ForEach(item => Console.WriteLine($"id = {item.Id}   Nom = {item.Nom} Email= {item.Email} Phone {item.Phone}"));

    // foreach (var item in list)
    // {
    //     Console.WriteLine($"id = {item.Id}   Nom = {item.Nom} Email= {item.Email} Phone {item.Phone}");
    // }


}


//Supperimer un element dans la table
using (var context = new MyDbContextSNTL())
{

   // var client = context.Clients.Where(a => a.Id == 1).FirstOrDefault();
    var clientByFind = context.Clients.Find(4);
    
    if (clientByFind != null)
    {
        context.Clients.Remove(clientByFind);
        context.SaveChanges();
    }
}


//pour la modifications
using (var context = new MyDbContextSNTL())
{
    var client = context.Clients.Where(a => a.Id == 2).FirstOrDefault();

    if (client != null)
    {
        client.Nom += " Amine";
        context.SaveChanges();
    }
}

*/
// delete all 
using (var context = new MyDbContextSNTL())
{
    var allClients = context.Clients.ToList(); // Récupérer tous les enregistrements

    context.Clients.RemoveRange(allClients); // Supprimer tous les enregistrements

    context.SaveChanges(); // Appliquer les changements

    var AllConventions = context.Conventions.ToList();
    context.Conventions.RemoveRange(AllConventions); // Supprimer tous les enregistrements
    context.SaveChanges(); // Appliquer les changements
}


using (var context = new MyDbContextSNTL())
{
    using(var tr = context.Database.BeginTransaction())
    {
        try
        {
            Random random = new Random();
            // Choose a random number between 1 and 6 for the prefix
            int prefixNumber = random.Next(0, 99); // Generates a number between 1 and 9
            
            // Format the prefix as two digits (e.g., 01, 02, ..., 06)
            string prefix = prefixNumber.ToString("D2"); // "D2" ensures two-digit formatting
            

            for (int i = 1; i <= 10; i++)
            {
                var client = new Client
                {
                    Nom = "Client " + i,
                    Email = "Client" + i + "@gmail.com",
                    Phone = "06" + random.Next(0, 99).ToString("D2") + 
                            random.Next(0, 99).ToString("D2") +
                            random.Next(0, 99).ToString("D2") + 
                            random.Next(0, 99).ToString("D2"),
                    Address = "Address " + i ,
                    CreatedAt = DateTime.Now
        
                
                };
                context.Clients.Add(client);
                 context.SaveChanges();

                        var Convention = new Convention{
                            ClientId = client.Id,
                            Name = "Convention " + client.Id,
                            StarDate = DateTime.Now,
                            EndDate  = DateTime.Now.AddDays(5 * 365), // 5ans
                            Status = TypeConvention.Conference,

                        };
                
                        context.Conventions.Add(Convention);
                        
                context.SaveChanges();
            }


            tr.Commit();
        }
        catch (Exception ex)
        {
            tr.Rollback();
            Console.WriteLine(ex.Message);
        }
    }
}
