using Microsoft.AspNetCore.Mvc;
using Conner.Application.Interfaces;

namespace ConnerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class EducationController : Controller
{
    private readonly IEducationService _educationService;

    public EducationController(IEducationService educationService)
    {
        _educationService = educationService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var education = await _educationService.GetAllEducationAsync();
        return Ok(education);
    }
}
