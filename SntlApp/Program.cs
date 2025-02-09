// See https://aka.ms/new-console-template for more information
using DemoLib;
using Humanizer;

#region 
/*
var clients  = new List<Client> {
    new Client { Id = 1, Name = "Jalal EL KASMI", Address = "123 street najma ", City = "Kenitra", 
                Country = "MAR", Phone = "0662-458698", DateOfBirth= new DateOnly(1990, 4, 30), Salary = 100000.00 },
    new Client { Id = 2, Name = "Mohamed IDRISSI", Address = "689 street el hocima", City = "Rabat", 
                Country = "MAR", Phone = "0680632574", DateOfBirth= new DateOnly(2000, 11, 25), Salary = 6520.00 },
    new Client { Id = 3, Name = "Imane NADID", Address = "25 street al majd", City = "Marrakech", 
                Country = "MAR", Phone = "0763569978",  DateOfBirth= new DateOnly(1987, 3, 15), Salary = 9854.00 }
    };
clients.RemoveAll(c => c.Salary < 10000.00);
clients.Insert(1, new Client { Id = 4, Name = "Yassine EL KASMI", Address = "123 street baghdad ", City = "Sale", 
                Country = "MAR", Phone = "0668-002266", DateOfBirth= new DateOnly(1995, 3, 5), Salary = 8590.00 });
clients.Sort((c1, c2) => string.Compare(c1.Name, c2.Name, StringComparison.Ordinal));
foreach (var client in clients)
{
    Console.WriteLine($"Id: {client.Id}, Name: {client.Name}, Address: {client.Address}, " +
                      $"City: {client.City}, Country: {client.Country}, Phone: {client.Phone}, " +
                      $"DateOfBirth: {client.DateOfBirth}, Salary: {client.Salary}");
}
*/
#endregion
/*
     try
        {
            List<string> listStrings = new List<string> { "1", "2", "three", "4" };

            // Utilisation de LINQ pour convertir les chaînes en entiers
            var integers = listStrings.Select(s => int.Parse(s)).ToList();

            // Affichage des entiers
            foreach (var i in integers)
            {
                Console.WriteLine(i);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Une exception s'est produite : " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Une exception inattendue s'est produite : " + ex.Message);
        }
 */   

static void HumanizeQuantities()
{
    Console.WriteLine("case".ToQuantity(0));
    Console.WriteLine("case".ToQuantity(1));
    Console.WriteLine("case".ToQuantity(5));
}

static void HumanizeDates()
{
    Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
    Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
    Console.WriteLine(TimeSpan.FromDays(1).Humanize());
    Console.WriteLine(TimeSpan.FromDays(16).Humanize());
}

Console.WriteLine("Quantities:");
HumanizeQuantities();

Console.WriteLine("\nDate/Time Manipulation:");
HumanizeDates();