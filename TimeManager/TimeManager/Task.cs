using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double EstimatedHours { get; set; }

        public override string ToString()
        {
            return $"Task id: {this.Id}\nName: {this.Name}\nDescription: {this.Description}\nEstimated Hours: {this.EstimatedHours}\n" ;
        }
    }
}
