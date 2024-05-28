using Conner.Application.DTOs;
using Conner.Application.Interfaces;
using Conner.Domain.Entities;

namespace Conner.Infrastructure;

public class StoryService : IStoryService
{
    public async Task<IEnumerable<StoryDTO>> GetStoryAsync()
    {
        var story = new List<StoryDTO>()
        {
            new StoryDTO()
            {
                Paragraphs =
                [
                    "Hi there! My name's Conner. I'm a full-stack software engineer living in Los Angeles. I appreciate you taking a look at this API!",
                    "I'm looking for a full-time role right now, and if you're here and you're hiring, maybe you should consider me as you're star candidate! This API is built using .NET and the frontend (which I assume you're calling this from) is built with React.js. This is the tech stack I typically use, the stack I enjoy using the most, and what I'd prefer to work with in my full-time job. With that said, I am completely open to using other tech stacks! I've used a multitude of different backend and frontend frameworks, and I'm also always excited to learn something new!",
                    "Some of the technologies I'm familiar with are .Net, React, Python Flask, Django, Vue, Unity (I enjoy a game jam every now and then), and Node.js. Most of my database connections are made with mySQL or Firebase.",
                    "I recently went back to school to get a Computer Science degree, and I'm incredibly excited with my new career path. I've always really loved puzzles, and I feel like software engineering is the ultimate puzzle to figure out. There's always an answer, and the answer is very rarely obvious. This field just feels right to me, and even though I don't have my foot in the door yet, I'll never stop building things.",
                    "Before starting my software engineering journey, I worked in health compliance for a non-profit in Oklahoma called Sunbeam. In this role, I maintained a huge database of children that actively attend one of 17 school sites or attended sometime in the past 4 years. If you have kids, you know that kids have a ton of doctor's appointments. I tracked those appointments for each child and made sure that if there were any individual medical needs that needed tending to in the classroom, we were taking care of those.",
                    "The majority of families that attended these school sites were involved with government assistance programs like TANF, WIC, and DHS, or had some kind of medical, developmental, or financial need. Working with these families was one of the most rewarding experiences I could have asked for, and I'm incredibly thankful that I had the opportunity to have that experience.",
                    "While I worked at Sunbeam, I was also a member of the National Guard. There, I got to work my way up as a private packing ammunition, to a sergeant serving as the fire direction and control chief of a mortar section. It was a huge honor to be able to serve in such a pivotal role in my platoon, and I really enjoyed the work and the people I met through the service.",
                    "Working with databases at Sunbeam and operating mortar fire computers with the Guard, in addition to doing Twitch streams and a lifelong video game obsession, is what really got me interested in programming and creating useful tools for niche needs!",
                    "I think I could bring a very unique experience to a software team. And that experience informs the way I go about solving problems! I have a lot of value to offer, I just need the chance to make your team better!"
                ],
                Links =
                [
                    "LinkedIn: https://www.linkedin.com/in/conner-hufnagel-070243287/",
                    "Github: https://github.com/conner-huf",
                    "Portfolio: https://conner-huf.github.io/portfolio-site/",
                    "Email: conner.huf@gmail.com"
                ]
            }
        };
        return await Task.FromResult(story);
    }
}
