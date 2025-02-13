using System.ComponentModel.DataAnnotations.Schema;
using ConsoleAppEF.Entities;

[Table("T_Client")]
public class Client : Base {
    public string? Nom { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public List<Convention>? Conventions { get; set; }


}