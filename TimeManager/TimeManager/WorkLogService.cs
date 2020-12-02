using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class WorkLogService
    {
        public static int counter = 0;
        public List<WorkLog> WorkLogs { get; set; }
        private ProjectService _projectService;
        private TaskService _taskService;

        public WorkLogService()
        {

        }
        public WorkLogService(ProjectService projectService, TaskService taskService)
        {
            _projectService = projectService;
            _taskService = taskService;
            WorkLogs = new List<WorkLog>();
        }

        public int AddNewLog(bool showLastlog = false)
        {
            if(showLastlog)
            {
                ShowLastLog();
            }
            var id = WorkLogService.counter + 1;
            _projectService.ShowList();
            var projectId = Helpers.GetIntNumber("1. Please enter project Id:");
            var project = _projectService.GetProjectById(projectId);
            Console.Clear();

            _taskService.ShowList();
            var taskId = Helpers.GetIntNumber("2. Please enter task Id:");
            var task = _taskService.GetTaskById(taskId);
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
        public void ShowLastLog()
        {
            Console.WriteLine("Last worklog:");
            ShowDetails(WorkLogs.Count - 1);
            Console.WriteLine("--------------------------------------------------\n");
        }

        public WorkLog GetLogById(int id)
        {
            WorkLog existingLog = null;
            foreach (var log in WorkLogs)
            {
                if (log.Id == id)
                    existingLog = log;
            }
            return existingLog;
        }

        public void ShowDetails(int id)
        {
            WorkLog existingLog = GetLogById(id);

            if (existingLog != null)
                Console.WriteLine(existingLog);
            else
                Console.WriteLine("Project not found");
        }

        public void CreateMockData()
        {

            WorkLogs = new List<WorkLog>()
            {
                new WorkLog()
                {
                    Id = 1,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[1],
                    Date = new DateTime(2020,12,1),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 2,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[1],
                    Date = new DateTime(2020,12,2),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 3,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[2],
                    Date = new DateTime(2020,12,3),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 4,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[2],
                    Date = new DateTime(2020,12,4),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 5,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[3],
                    Date = new DateTime(2020,12,5),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 6,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[3],
                    Date = new DateTime(2020,12,6),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 7,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[4],
                    Date = new DateTime(2020,12,7),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 8,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[4],
                    Date = new DateTime(2020,12,8),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 9,
                    Project = null,
                    Task = null,
                    Date = new DateTime(2020,12,8),
                    Presence = Presence.SickLeave,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 10,
                    Project = null,
                    Task = null,
                    Date = new DateTime(2020,12,9),
                    Presence = Presence.SickLeave,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 11,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[5],
                    Date = new DateTime(2020,12,11),
                    Presence = Presence.Delegation,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 12,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[5],
                    Date = new DateTime(2020,12,12),
                    Presence = Presence.Delegation,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },
            };
        }
    }
}
