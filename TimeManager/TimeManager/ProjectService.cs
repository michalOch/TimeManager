using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class ProjectService
    {
        public List<Project> Projects { get; set; }
        public ProjectService()
        {
            Projects = new List<Project>();
        }
    }
}
