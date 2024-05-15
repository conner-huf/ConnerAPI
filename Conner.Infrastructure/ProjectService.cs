using Conner.Application.DTOs;
using Conner.Application.Interfaces;
using Conner.Domain.Entities;

namespace Conner.Infrastructure.Services;

public class ProjectService : IProjectService
{
    public async Task<IEnumerable<ProjectDTO>> GetAllProjectsAsync()
    {
        // TODO:
        // Dummy data - will be replaced with database calls in future
        var projects = new List<ProjectDTO>
        {
            new ProjectDTO
            {
                Id = 1,
                Category = ProjectCategory.FullStack,
                ProjectName = "Portfolio Site",
                ProjectDescription = "The site you're currently on! This is my longest running project and I'm incredibly proud of how it has turned out and improved from where it started. I'm constantly changing styles and updating content as I learn more. As soon as I start to feel comfortable with where this site is, I get a new idea to run with, so it's always changing. Hosted on Github Pages.",
                Technologies = new List<string> { "React.js", "HTML", "CSS", "Github" },
                SourceCodeLink = "https://github.com/conner-huf/portfolio-site",
                LiveDemoLink = "https://conner-huf.github.io/portfolio-site/",
                ImageLink = "https://image1.com"
            },
            new ProjectDTO
            {
                Id = 2,
                Category = ProjectCategory.FullStack,
                ProjectName = "Noodle",
                ProjectDescription = "A full-stack application for finding concerts in your local area. This is my largest scale project, and I'm hoping to link this with an affiliate code with ticketmaster if I can get approved at some point! I'm really proud of how this has turned out, and I continually improve it as I think of ideas. Uses Python Flask, React.js, Leaflet, TicketmasterAPI, SpotifyAPI, Heroku.",
                Technologies = new List<string> { "React.js", "Python", "Flask", "Github", "Heroku", "APIs" },
                SourceCodeLink = "https://github.com/conner-huf/noodle",
                LiveDemoLink = "https://conner-huf.github.io/noodle/",
                ImageLink = "https://image2.com"
            },
            new ProjectDTO
            {
                Id = 3,
                Category = ProjectCategory.FullStack,
                ProjectName = "Teeny Link",
                ProjectDescription = "An application that can shorten a url. Uses Firebase to store target long URLs and generated short URLs. Made using React, Python Flask, Firebase, Heroku. This was a fun project that I mainly wanted to make so that I could create more consistent looking links to all of my things, and I wanted to learn more about how to use firebase. I have since limited the database access to read only to ensure that I'm not charged, so unfortunately links can no longer be created. But the links created in the first month still work.",
                Technologies = new List<string> { "React.js", "HTML", "CSS", "Github", "Heroku", "Python", "Flask", "Firebase" },
                SourceCodeLink = "https://github.com/conner-huf/teeny-link",
                LiveDemoLink = "https://www.teeny-link.com/app",
                ImageLink = "https://image1.com"
            },
            new ProjectDTO
            {
                Id = 4,
                Category = ProjectCategory.FrontEnd,
                ProjectName = "Pokedex App",
                ProjectDescription = "An application that fetches data from the PokeApi to display information on the Pokemon game series. Made using React, PokeApi.co, and Node.js. This web app chugs through a lot of information to display the data, so it was a fun challenge to make it as efficient as possible.",
                Technologies = new List<string> { "React.js", "Node.js", "CSS", "HTML", "Github", "APIs" },
                SourceCodeLink = "https://github.com/conner-huf/pokedex",
                LiveDemoLink = "https://conner-huf.github.io/pokedex/",
                ImageLink = "https://image1.com"
            },
            new ProjectDTO
            {
                Id = 5,
                Category = ProjectCategory.GameDev,
                ProjectName = "Asteroids",
                ProjectDescription = "A game inspired by the asteroids arcade game. Built using Unity. I really enjoy working with Unity, and I think this was a great way to get more acquainted with it. In my free time I like to play around with Unity and see what I can make, but this is the only complete project that I currently have available.",
                Technologies = new List<string> { "Unity", "C#" },
                SourceCodeLink = "https://github.com/conner-huf/Asteroids",
                LiveDemoLink = "https://itzlumpz.itch.io/asteroids",
                ImageLink = "https://image1.com"
            },
            new ProjectDTO
            {
                Id = 6,
                Category = ProjectCategory.GameDev,
                ProjectName = "Evermana",
                ProjectDescription = "An addon I created for the popular MMO World of Warcraft. Displays the current mana points of the player in circumstances when it is not visible by default. I really like this project because I think it demonstrates a good approach to software solutions. I had an issue with the UI on WoW, I researched how I could fix it, and not only did I want to fix it, I acted on it.",
                Technologies = new List<string> { "Lua", "APIs", "Scripts" },
                SourceCodeLink = "https://github.com/conner-huf/EverMana",
                LiveDemoLink = "https://github.com/conner-huf/EverMana",
                ImageLink = "https://image1.com"
            },
            new ProjectDTO
            {
                Id = 7,
                Category = ProjectCategory.FullStack,
                ProjectName = "Spotify Clone",
                ProjectDescription = "A study into recreating the Spotify web application's design and functionality. Made using React.js, Node.js, TailwindCSS, Github, and Supabase.",
                Technologies = new List<string> { "React.js", "Node.js", "HTML", "TailwindCSS", "Github", "Supabase" },
                SourceCodeLink = "https://github.com/conner-huf/spotify-clone",
                LiveDemoLink = "https://spotify-clone-sable-three.vercel.app/",
                ImageLink = "https://image1.com"
            },
            new ProjectDTO
            {
                Id = 8,
                Category = ProjectCategory.FrontEnd,
                ProjectName = "Restaurant Demo Site",
                ProjectDescription = "A demo site for a restaurant to display their menu, about page, and contact information. Made using React.js, HTML, and CSS. Hosted on Github Pages.",
                Technologies = new List<string> { "React.js", "HTML", "CSS", "Github"},
                SourceCodeLink = "https://github.com/conner-huf/restaurant-site",
                LiveDemoLink = "https://conner-huf.github.io/restaurant-site/",
                ImageLink = "https://image1.com"
            },
        };

        return await Task.FromResult(projects);
    }
}