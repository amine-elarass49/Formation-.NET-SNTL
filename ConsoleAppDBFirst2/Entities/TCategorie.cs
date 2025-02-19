using System;
using System.Collections.Generic;

namespace ConsoleAppDBFirst2.Entities;

public partial class TCategorie
{
    public int Id { get; set; }

    public string? Categorie { get; set; }

    public virtual ICollection<TProduit> TProduits { get; set; } = new List<TProduit>();
}
