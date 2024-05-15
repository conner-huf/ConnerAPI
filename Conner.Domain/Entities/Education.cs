namespace Conner.Domain.Entities;

public class Education
{
    public int Id { get; set; }
    public string? Type { get; set; }
    public string? Specialization { get; set; }
    public DateTime DateReceived { get; set; }
    public string? IssuingEntity { get; set; }
}
