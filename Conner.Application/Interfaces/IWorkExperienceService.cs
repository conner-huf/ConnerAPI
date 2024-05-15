using Conner.Application.DTOs;

namespace Conner.Application.Interfaces;

public interface IWorkExperienceService
{
    Task<IEnumerable<WorkExperienceDTO>> GetAllWorkExperienceAsync();
}


