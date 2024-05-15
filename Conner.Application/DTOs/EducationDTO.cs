namespace Conner.Application.DTOs;

public class EducationDTO
{
    public int Id { get; set; }
    public string? Type { get; set; }
    public string? Specialization { get; set; }
    public DateTime DateReceived { get; set; }
    public string? IssuingEntity { get; set; }
}
