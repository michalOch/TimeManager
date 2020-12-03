using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class WorkLogService
    {
        // Based on mock data
        public static int counter = 41;
        public List<WorkLog> WorkLogs { get; set; }
        private ProjectService _projectService;
        private TaskService _taskService;
        private MockWorkLog _mockWorkLog;

        public WorkLogService()
        {

        }
        public WorkLogService(ProjectService projectService, TaskService taskService)
        {
            _projectService = projectService;
            _taskService = taskService;
            _mockWorkLog = new MockWorkLog(_projectService, _taskService);
            WorkLogs = new List<WorkLog>();
            GetMockData();
        }

        public void GetMockData()
        {
            WorkLogs = _mockWorkLog.CreateMockData();
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

        public void Remove(int id)
        {
            WorkLog logToRemove = GetLogById(id);

            if (logToRemove != null)
                WorkLogs.Remove(logToRemove);
            else
                Console.WriteLine("Worklog not found");
        }

        public void ShowDetails(int id)
        {
            WorkLog existingLog = GetLogById(id);

            if (existingLog != null)
                Console.WriteLine(existingLog);
            else
                Console.WriteLine("Worklog not found");
        }

        public void ShowAll()
        {
            foreach (var log in WorkLogs)
            {
                Console.WriteLine(log);
                Console.WriteLine("--------------------------------------------------\n");
            }
        }

    }
}
