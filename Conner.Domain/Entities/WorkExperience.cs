namespace Conner.Domain.Entities;

public class WorkExperience
{
    public int Id { get; set; }
    public string EmployerName { get; set; } = default!;
    public string JobTitle { get; set; } = default!;
    public string JobDescription { get; set; } = default!;
    public List<string> JobImpacts { get; set; } = default!;
    public string SupervisorName { get; set; } = default!;
    public string SupervisorTitle { get; set; } = default!;
    public string? SupervisorContactEmail { get; set; }

}
