// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using ConsoleAppEF.Infra.Data;
using Microsoft.Extensions.Logging;

// Add a Console Trace Listener manually
/* Trace.Listeners.Add(new ConsoleTraceListener());
Console.WriteLine("Hello, World!");
Trace.WriteLine("This is a trace message when tracing the app.");
Debug.WriteLine("This is a debug message just for developers.");*/

// CodeFirst Formation SNTL

//La création
using (var context = new MyDbContextSNTL())
{

    Client client = new Client
    {
        Nom = "EL ARASS",
        Address= "Address 2",
        Email = "aelarass@sntl.ma",
        Phone = "0662125712"
    };
    context.Clients.Add(client);
    context.SaveChanges();
}



//Pour voire la liste des catégories
using (var context = new MyDbContextSNTL())
{
    var list = context.Clients.ToList();

    foreach (var item in list)
    {
        Console.WriteLine($"id = {item.Id}   Nom = {item.Nom} Email= {item.Email} Phone {item.Phone}");
    }


}

/*
//Supperimer un element dans la table
using (var context = new MyDbContextSNTL())
{

    var categorie = context.Categories.Where(a => a.Id == 1).FirstOrDefault();
    var categorieByFind = context.Categories.Find(1);

    if (categorie != null)
    {
        context.Categories.Remove(categorie);
        context.SaveChanges();
    }
}

//pour la modifications
using (var context = new MyDbContextSNTL())
{
    var categorie = context.Categories.Where(a => a.Id == 2).FirstOrDefault();
    if (categorie != null)
    {
        categorie.Nom = "Smart TV";

        context.SaveChanges();
    }
}



using (var context = new MyDbContextSNTL())
{
    using(var tr = context.Database.BeginTransaction())
    {
        try
        {

            for (int i = 0; i < 10; i++)
            {
                Categorie categorie = new Categorie
                {
                    Nom = "Categorie " + i.ToString()
                };
                context.Categories.Add(categorie);
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

*/


