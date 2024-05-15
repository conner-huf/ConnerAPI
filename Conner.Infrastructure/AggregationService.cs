using Conner.Application.DTOs;
using Conner.Application.Interfaces;
using Conner.Domain.Entities;

namespace Conner.Infrastructure.Services;

public class AggregationService : IAggregationService 
{

    private readonly IWorkExperienceService _workExperienceService;
    private readonly IProjectService _projectsService;
    private readonly IEducationService _educationService;

    public AggregationService(
       IWorkExperienceService workExperienceService,
       IProjectService projectsService,
       IEducationService educationService)
    {
        _workExperienceService = workExperienceService;
        _projectsService = projectsService;
        _educationService = educationService;
    }

    public async Task<ResumeDTO> GetResumeAsync()
    {

        var _workExperience = await _workExperienceService.GetAllWorkExperienceAsync();
        var _projects = await _projectsService.GetAllProjectsAsync();
        var _education = await _educationService.GetAllEducationAsync();

        var resumeToReturn = new ResumeDTO
        {
            workExperience = _workExperience,
            projects = _projects,
            education = _education
        };
        
        return await Task.FromResult(resumeToReturn);
    }
}