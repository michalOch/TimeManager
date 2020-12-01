using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class ProjectService
    {
        public static int counter = 0;
        public List<Project> Projects { get; set; }
        public ProjectService()
        {
            Projects = new List<Project>();
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
