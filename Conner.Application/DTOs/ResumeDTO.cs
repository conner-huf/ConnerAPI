namespace Conner.Application.DTOs;

public class ResumeDTO
{
    public IEnumerable<WorkExperienceDTO> workExperience { get; set; }
    public IEnumerable<ProjectDTO> projects { get; set; }
    public IEnumerable<EducationDTO> education { get; set; }
}
