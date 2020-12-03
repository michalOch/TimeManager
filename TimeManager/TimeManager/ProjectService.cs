using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class ProjectService
    {
        // set for mock data and tests
        private MockProject mockProject;
        public static int counter = 7;
        public List<Project> Projects { get; set; }
        public ProjectService()
        {
            // mock data for tests
            Projects = new List<Project>();
            mockProject = new MockProject();
            GetMockData();
        }

        public void GetMockData()
        {
            Projects = mockProject.GetMockData();
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

        public Project GetProjectById(int id)
        {
            Project existingProject = null;
            foreach (var project in Projects)
            {
                if (project.Id == id)
                    existingProject = project;
            }
            return existingProject;
        }

        public void ShowDetails(int id)
        {
            Project existingProject = GetProjectById(id);

            if (existingProject != null)
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

        public void ShowList()
        {
            Console.WriteLine("Avaliable projects:");
            foreach (var project in Projects)
            {
                Console.WriteLine($"{project.Id}: {project.Name} ");
            }
            Console.WriteLine("--------------------------------------------------\n");
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
