using Conner.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConnerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class StoryController : ControllerBase
{
    private readonly IStoryService _storyService;

    public StoryController(IStoryService storyService)
    {
        _storyService = storyService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var story = await _storyService.GetStoryAsync();
        return Ok(story);
    }
}
