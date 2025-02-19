namespace ConsoleAppEF.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Convention : Base{
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }
    public string? Description { get; set; }
    [Required]
    public DateTime StarDate { get; set; }
    public DateTime EndDate { get; set; }
    public TypeConvention Status { get; set; } = TypeConvention.Formation;
    [ForeignKey("Client")]
    public int ClientId { get; set; }
}




public enum TypeConvention{
    Formation=0, Seminaire=1, Atelier=2, Conference=3
}