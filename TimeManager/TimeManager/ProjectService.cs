using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class ProjectService
    {
        // set for mock data and tests
        public static int counter = 7;
        public List<Project> Projects { get; set; }
        public ProjectService()
        {
            // mock data for tests
            Projects = new List<Project>()
            {
                new Project()
                {
                    Id = 1,
                    Name = "Sapa",
                    ExternalId = "00000001",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Proin sed libero enim sed faucibus turpis in eu mi. Lacus sed viverra tellus in hac habitasse platea dictumst. Consectetur purus ut faucibus pulvinar elementum integer enim neque. "
                },
                new Project()
                {
                    Id = 2,
                    Name = "Andersen Steel",
                    ExternalId = "00000002",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Proin sed libero enim sed faucibus turpis in eu mi. Lacus sed viverra tellus in hac habitasse platea dictumst. Consectetur purus ut faucibus pulvinar elementum integer enim neque. "
                },
                new Project()
                {
                    Id = 3,
                    Name = "Lubella",
                    ExternalId = "00000003",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Proin sed libero enim sed faucibus turpis in eu mi. Lacus sed viverra tellus in hac habitasse platea dictumst. Consectetur purus ut faucibus pulvinar elementum integer enim neque. "
                },
                new Project()
                {
                    Id = 4,
                    Name = "Volkswagen",
                    ExternalId = "00000004",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Proin sed libero enim sed faucibus turpis in eu mi. Lacus sed viverra tellus in hac habitasse platea dictumst. Consectetur purus ut faucibus pulvinar elementum integer enim neque. "
                },
                new Project()
                {
                    Id = 5,
                    Name = "Bella",
                    ExternalId = "00000005",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Proin sed libero enim sed faucibus turpis in eu mi. Lacus sed viverra tellus in hac habitasse platea dictumst. Consectetur purus ut faucibus pulvinar elementum integer enim neque. "
                },
                new Project()
                {
                    Id = 6,
                    Name = "Jabil",
                    ExternalId = "00000006",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Proin sed libero enim sed faucibus turpis in eu mi. Lacus sed viverra tellus in hac habitasse platea dictumst. Consectetur purus ut faucibus pulvinar elementum integer enim neque. "
                },
                new Project()
                {
                    Id = 7,
                    Name = "Zentex",
                    ExternalId = "00000007",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Proin sed libero enim sed faucibus turpis in eu mi. Lacus sed viverra tellus in hac habitasse platea dictumst. Consectetur purus ut faucibus pulvinar elementum integer enim neque. "
                },
            };
        }

        public int AddNewProject()
        {      
            var id = ProjectService.counter + 1;
            var name = Helpers.GetStringValue("1. Please enter new project name:");
            var externalId = Helpers.GetStringValue("2. Please enter external Id (SAP number):");
            var description = Helpers.GetStringValue("3. Please short describe your project:");
            Project newProject = new Project()
            {
                Id = id,
                Name = name,
                ExternalId = externalId,
                Description = description
            };
            Projects.Add(newProject);
            counter++;
            return newProject.Id;
        }

        public void ShowDetails(int id)
        {
            Project existingProject = null;
            foreach (var project in Projects)
            {
                if(project.Id == id)    
                    existingProject = project;
            }

            if(existingProject != null)
                Console.WriteLine(existingProject);
            else
                Console.WriteLine("Project not found");
        }

        public void ShowAll()
        {
            foreach (var project in Projects)
            {
                Console.WriteLine(project);
            }
        }

        public void Remove(int id)
        {
            Project projectToRemove = null;
            foreach (var project in Projects)
            {
                if (project.Id == id)
                    projectToRemove = project;
            }
            if (projectToRemove != null)
                Projects.Remove(projectToRemove);
            else
                Console.WriteLine("Project not found");
        }
    }
}
