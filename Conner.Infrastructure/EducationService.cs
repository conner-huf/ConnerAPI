using Conner.Application.DTOs;
using Conner.Application.Interfaces;

namespace Conner.Infrastructure.Services;

public class EducationService : IEducationService
{
    public async Task<IEnumerable<EducationDTO>> GetAllEducationAsync()
    {
        var education = new List<EducationDTO>
        {
            new EducationDTO
            {
                Id = 1,
                Type = "Bachelor's of Science",
                Specialization = "Computer Science",
                DateReceived = new DateTime(2023, 11, 01, 0, 0, 0),
                IssuingEntity = "Southern New Hampshire University"
            },
            new EducationDTO
            {
                Id = 2,
                Type = "Professional Certification",
                Specialization = "Introduction to Front-End Development",
                DateReceived = new DateTime(2023, 05, 28, 0, 0, 0),
                IssuingEntity = "Meta"
            },
            new EducationDTO
            {
                Id = 3,
                Type = "Professional Certification",
                Specialization = "Programming with JavaScript",
                DateReceived = new DateTime(2023, 06, 20, 0, 0, 0),
                IssuingEntity = "Meta"
            },
            new EducationDTO
            {
                Id = 4,
                Type = "Professional Certification",
                Specialization = "Version Control",
                DateReceived = new DateTime(2023, 08, 05, 0, 0, 0),
                IssuingEntity = "Meta"
            },
            new EducationDTO
            {
                Id = 5,
                Type = "Professional Certification",
                Specialization = "HTML and CSS in Depth",
                DateReceived = new DateTime(2023, 08, 21, 0, 0, 0),
                IssuingEntity = "Meta"
            },
            new EducationDTO
            {
                Id = 6,
                Type = "Professional Certification",
                Specialization = "React Basics",
                DateReceived = new DateTime(2023, 08, 29, 0, 0, 0),
                IssuingEntity = "Meta"
            },
            new EducationDTO
            {
                Id = 7,
                Type = "Professional Certification",
                Specialization = "Advanced React",
                DateReceived = new DateTime(2023, 09, 14, 0, 0, 0),
                IssuingEntity = "Meta"
            },
            new EducationDTO
            {
                Id = 8,
                Type = "Professional Certification",
                Specialization = "Principles of UX/UI Design",
                DateReceived = new DateTime(2023, 09, 20, 0, 0, 0),
                IssuingEntity = "Meta"
            },
            new EducationDTO
            {
                Id = 9,
                Type = "Professional Certification",
                Specialization = "Front-End Developer Capstone",
                DateReceived = new DateTime(2023, 10, 25, 0, 0, 0),
                IssuingEntity = "Meta"
            },
            new EducationDTO
            {
                Id = 10,
                Type = "Professional Certification",
                Specialization = "Coding Interview Preparation",
                DateReceived = new DateTime(2023, 10, 27, 0, 0, 0),
                IssuingEntity = "Meta"
            },
            new EducationDTO
            {
                Id = 11,
                Type = "Professional Certification",
                Specialization = "Introduction to Mobile Development",
                DateReceived = new DateTime(2023, 11, 05, 0, 0, 0),
                IssuingEntity = "Meta"
            },
            new EducationDTO
            {
                Id = 12,
                Type = "Professional Certification",
                Specialization = "Foundations: Data, Data, Everywhere",
                DateReceived = new DateTime(2023, 05, 27, 0, 0, 0),
                IssuingEntity = "Google"
            },
            new EducationDTO
            {
                Id = 13,
                Type = "Professional Certification",
                Specialization = "Introduction to Cloud Computing",
                DateReceived = new DateTime(2024, 04, 12, 0, 0, 0),
                IssuingEntity = "IBM"
            },
            new EducationDTO
            {
                Id = 14,
                Type = "Professional Certification",
                Specialization = "Developing Back-End Apps with Node.js and Express",
                DateReceived = new DateTime(2024, 04, 15, 0, 0, 0),
                IssuingEntity = "IBM"
            },
            new EducationDTO
            {
                Id = 15,
                Type = "Professional Certification",
                Specialization = "Developing AI Applications with Python and Flask",
                DateReceived = new DateTime(2024, 04, 18, 0, 0, 0),
                IssuingEntity = "IBM"
            },
            new EducationDTO
            {
                Id = 16,
                Type = "Professional Certification",
                Specialization = "Introduction to Web Development with HTML, CSS, JavaScript",
                DateReceived = new DateTime(2024, 04, 16, 0, 0, 0),
                IssuingEntity = "IBM"
            },
            new EducationDTO
            {
                Id = 17,
                Type = "Professional Certification",
                Specialization = "Python for Data Science, AI, & Development",
                DateReceived = new DateTime(2024, 01, 07, 0, 0, 0),
                IssuingEntity = "IBM"
            },
            new EducationDTO
            {
                Id = 18,
                Type = "Professional Certification",
                Specialization = "Developing Front-End Apps with React",
                DateReceived = new DateTime(2024, 04, 26, 0, 0, 0),
                IssuingEntity = "IBM"
            },
            new EducationDTO
            {
                Id = 19,
                Type = "Professional Certification",
                Specialization = "Getting Started with Git and GitHub",
                DateReceived = new DateTime(2024, 04, 16, 0, 0, 0),
                IssuingEntity = "IBM"
            },
        };

        return await Task.FromResult(education);
    }
}