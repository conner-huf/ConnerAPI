using Conner.Application.DTOs;

namespace Conner.Application.Interfaces;

public interface IAggregationService
{
    Task<ResumeDTO> GetResumeAsync();
}
