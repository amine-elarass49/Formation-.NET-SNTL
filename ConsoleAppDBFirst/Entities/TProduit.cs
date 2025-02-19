using System;
using System.Collections.Generic;

namespace ConsoleAppDBFirst.Entities;

public partial class TProduit
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? CodeProduit { get; set; }

    public decimal? PrixUnitaire { get; set; }

    public int? IdCategorie { get; set; }

    public virtual TCategorie? IdCategorieNavigation { get; set; }

    public virtual ICollection<TDetailCommande> TDetailCommandes { get; set; } = new List<TDetailCommande>();
}
