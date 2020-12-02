using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class WorkLog
    {
        public int Id { get; set; }
        public Project Project { get; set; }
        public Task Task { get; set; }
        public DateTime Date { get; set; }
        public Presence Presence { get; set; }
        public double TimeSpent { get; set; }
        public string Comment { get; set; }

        public override string ToString()
        {
            return $"Worklog id: {this.Id}\nProject: {this.Project.Name}\nTask: {this.Task.Name}\nStart date: {this.Date.ToShortDateString()}\nPresence: {Presence}\nTime spent: {TimeSpent}\nComment: {Comment}";
        }
    }
}
