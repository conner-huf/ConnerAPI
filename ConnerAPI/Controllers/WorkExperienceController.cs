using Microsoft.AspNetCore.Mvc;
using Conner.Application.Interfaces;

namespace ConnerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WorkExperienceController : Controller
{
    private readonly IWorkExperienceService _workExperienceService;

    public WorkExperienceController(IWorkExperienceService workExperienceService)
    {
        _workExperienceService = workExperienceService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var workExperience = await _workExperienceService.GetAllWorkExperienceAsync();
        return Ok(workExperience);
    }
}
