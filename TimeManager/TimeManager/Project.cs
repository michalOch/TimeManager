using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class Project
    {
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public State State { get; set; }
        public List<string> Tasks { get; set; }

        public override string ToString()
        {
            return $"Project id: {this.Id}\nName: {this.Name}\nExternal Id: {this.ExternalId}\nDescription: {this.Description}\n";
        }
    }
}
