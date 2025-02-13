namespace ConsoleAppEF.Entities;
public class Convention : Base{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime StarDate { get; set; }
    public DateTime EndDate { get; set; }
    public TypeConvention Status { get; set; } = TypeConvention.Formation;
    public int ClientId { get; set; }
}




public enum TypeConvention{
    Formation=0, Seminaire=1, Atelier=2, Conference=3
}