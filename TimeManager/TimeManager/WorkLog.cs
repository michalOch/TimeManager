using System;

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
            var projectName = Project != null ? Project.Name : "-";
            var taskName = Task != null ? Task.Name : "-";
            var date = Date != null ? Date.ToShortDateString() : "-";

            return $"Worklog id: {this.Id}\nProject: {projectName}\nTask: {taskName}\nStart date: {date}\nPresence: {Presence}\nTime spent: {TimeSpent}\nComment: {Comment}";
        }
    }
}
