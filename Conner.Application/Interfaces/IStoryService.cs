using Conner.Application.DTOs;

namespace Conner.Application.Interfaces;

public interface IStoryService
{
    Task<IEnumerable<StoryDTO>> GetStoryAsync();
}
