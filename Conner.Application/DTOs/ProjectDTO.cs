using Conner.Domain.Entities;
namespace Conner.Application.DTOs;

public class ProjectDTO
{
    
    public int Id { get; set; }
    public ProjectCategory Category { get; set;}
    public string ProjectName { get; set; } = default!;
    public string ProjectDescription { get; set; } = default!;
    public List<string> Technologies { get; set; } = default!;
    public string SourceCodeLink { get; set; } = default!;
    public string LiveDemoLink { get; set; } = default!;
    public string ImageLink { get; set; } = default!;

}