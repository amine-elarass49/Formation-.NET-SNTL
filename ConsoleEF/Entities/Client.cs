using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using ConsoleAppEF.Entities;

[Table("T_Client")]
public class Client : Base {
    [Required(ErrorMessage = "Le Nom est obligatoire.")] 
    [MaxLength(50, ErrorMessage = "Le Nom doit contenir 50 caracteres maximum.")]
    public string? Nom { get; set; }
    
    [EmailAddress(ErrorMessage ="L'e-mail doit etre respecter le format du email")]
    public string? Email { get; set; }

    [RegularExpression(@"^\d{10}$", ErrorMessage = "Le numéro de téléphone doit contenir 10 chiffres.")]
    public string? Phone { get; set; }

    [StringLength(100, ErrorMessage = "L'address ne peut pas dépasser 100 caractères.")]
    public string? Address { get; set; }

    [JsonIgnore]
    public ICollection<Convention>? Conventions { get; set; }


}