using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class WorkLogService
    {
        public static int counter = 0;
        public List<WorkLog> WorkLogs { get; set; }
        public WorkLogService()
        {
            WorkLogs = new List<WorkLog>();
        }

        public int AddNewLog(ProjectService projectService, TaskService taskService)
        {
            var id = WorkLogService.counter + 1;

            projectService.ShowList();
            var projectId = Helpers.GetIntNumber("1. Please enter project Id:");
            var project = projectService.GetProjectById(projectId);
            Console.Clear();

            taskService.ShowList();
            var taskId = Helpers.GetIntNumber("2. Please enter task Id:");
            var task = taskService.GetTaskById(taskId);
            Console.Clear();

            var date = Helpers.GetDate("3. Please enter start date (yyyy'-'MM'-'dd'): ");
            Console.Clear();

            // Set present
            Helpers.ShowPresences();
            var presenceId = Helpers.GetStringValue("5. Please enter presence type (default: Present):");
            Presence presence = Presence.Present;
            if (Enum.IsDefined(typeof(Presence), presenceId))
            {
                presence = (Presence)Enum.Parse(typeof(Presence), presenceId);
            }
            Console.Clear();

            var timeSpent = Helpers.GetDoubleNumber("6. Please enter time spent:");
            Console.Clear();

            var comment = Helpers.GetStringValue("7. Please enter additional comment:");
            Console.Clear();

            WorkLog newLog = new WorkLog()
            {
                Id = id,
                Project = project,
                Task = task,
                Date = date,
                Presence = presence,
                TimeSpent = timeSpent,
                Comment = comment
            };

            WorkLogs.Add(newLog);
            counter++;
            return newLog.Id;
        }
    }
}
