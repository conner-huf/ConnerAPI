using Microsoft.AspNetCore.Mvc;
using Conner.Application.Interfaces;

namespace ConnerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ResumeController : Controller
{
    private readonly IAggregationService _aggregationService;

    public ResumeController(IAggregationService aggregationService)
    {
        _aggregationService = aggregationService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var resume = await _aggregationService.GetResumeAsync();
        return Ok(resume);
    }
}
