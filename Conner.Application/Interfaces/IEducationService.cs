using Conner.Application.DTOs;

namespace Conner.Application.Interfaces;

public interface IEducationService
{
    Task<IEnumerable<EducationDTO>> GetAllEducationAsync();
}
