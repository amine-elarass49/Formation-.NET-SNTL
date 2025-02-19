using System;
using System.Collections.Generic;

namespace ConsoleAppDBFirst2.Entities;

public partial class TBonCommande
{
    public int Id { get; set; }

    public DateOnly? DateCommande { get; set; }

    public int? IdClient { get; set; }

    public int? EtatCommande { get; set; }

    public virtual TClient? IdClientNavigation { get; set; }

    public virtual ICollection<TDetailCommande> TDetailCommandes { get; set; } = new List<TDetailCommande>();
}
