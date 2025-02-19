using System;
using System.Collections.Generic;

namespace ConsoleAppDBFirst2.Entities;

public partial class TDetailCommande
{
    public int Id { get; set; }

    public int? IdCommande { get; set; }

    public int? IdProduit { get; set; }

    public decimal? Qnt { get; set; }

    public decimal? PrixUnitaire { get; set; }

    public decimal? Total { get; set; }

    public virtual TBonCommande? IdCommandeNavigation { get; set; }

    public virtual TProduit? IdProduitNavigation { get; set; }
}
