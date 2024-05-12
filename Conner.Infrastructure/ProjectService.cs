using Conner.Application.DTOs;
using Conner.Application.Interfaces;

namespace Conner.Infrastructure.Services;

public class ProjectService : IProjectService
{
    public async Task<IEnumerable<ProjectDto>> GetAllProjectsAsync()
    {
        // Dummy data
        var projects = new List<ProjectDto>
        {
            new ProjectDto
            {
                Id = 1,
                ProjectName = "Project 1",
                ProjectDescription = "Description 1",
                Technologies = new List<string> { "Tech 1", "Tech 2" },
                SourceCodeLink = "https://source1.com",
                LiveDemoLink = "https://demo1.com",
                ImageLink = "https://image1.com"
            },
            new ProjectDto
            {
                Id = 2,
                ProjectName = "Project 2",
                ProjectDescription = "Description 2",
                Technologies = new List<string> { "Tech 3", "Tech 4" },
                SourceCodeLink = "https://source2.com",
                LiveDemoLink = "https://demo2.com",
                ImageLink = "https://image2.com"
            }
        };

        return await Task.FromResult(projects);
    }
}