using System;
using System.Collections.Generic;

namespace ConsoleAppDBFirst.Entities;

public partial class TClient
{
    public int Id { get; set; }

    public string? Client { get; set; }

    public string? Adresse { get; set; }

    public virtual ICollection<TBonCommande> TBonCommandes { get; set; } = new List<TBonCommande>();
}
