using Conner.Application.DTOs;
using Conner.Application.Interfaces;

namespace Conner.Infrastructure.Services;

public class WorkExperienceService : IWorkExperienceService
{
    public async Task<IEnumerable<WorkExperienceDTO>> GetAllWorkExperienceAsync()
    {
        var workExperience = new List<WorkExperienceDTO> 
        {
            new WorkExperienceDTO
            {
                Id = 1,
                EmployerName = "Sunbeam Family Services",
                JobTitle = "Health Advocate",
                JobDescription = "Connect impoverished families with generalist and specialist providers and services based on individual needs. Additionally, maintain health standards to federal and state oversight standards.",
                JobImpacts = 
                    [
                        "Implemented new health compliance policies to better comply with federal health standards across 17 school sites.", 
                        "Achieved 92% compliance rate with a population over 1500 students, a 27% increase from when I started at Sunbeam.", 
                        "Led a team of 4 through a federal compliance audit, within which we had to provide health screenings for 500 currently active children within a 90-day time frame to maintain funding.",
                    ],
                SupervisorName = "Lynn Coutu",
                SupervisorTitle = "Health Coordinator"
            },
            new WorkExperienceDTO
            {
                Id = 2,
                EmployerName = "Oklahoma Army National Guard",
                JobTitle = "Mortar Fire Direction and Control Sergeant",
                JobDescription = "Train lower enlisted soldiers in standard mortar fire operations.",
                JobImpacts =
                    [
                        "Led a team of 4 in a Fire Direction and Control squad to accurately and efficiently execute indirect fire training missions.",
                        "Maintained accountability of sensitive, mission critical equipment valued at over $1,000,000.",
                        "Selected to be inducted into the Order of St. Maurice – an invite only, honorary infantry society for outstanding service.",
                    ],
                SupervisorName = "Kyle Wachtendorf",
                SupervisorTitle = "First Sergeant"
            }
        };

        return await Task.FromResult(workExperience);
    }
}
