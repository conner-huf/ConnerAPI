using Microsoft.AspNetCore.Mvc;
using Conner.Domain.Entities;
using Conner.Application.Interfaces;

namespace Conner.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectsController : ControllerBase
{
    private readonly IProjectService _projectService;

    public ProjectsController(IProjectService projectService)
    {
        _projectService = projectService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var projects = await _projectService.GetAllProjectsAsync();
        return Ok(projects);
    }
}
