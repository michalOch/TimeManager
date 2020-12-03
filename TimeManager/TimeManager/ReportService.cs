using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class ReportService
    {
        private WorkLogService _workLogService;
        private ProjectService _projectService;
        private TaskService _taskService;
        private List<WorkLog> WorkLogs;

        public ReportService(WorkLogService workLogService, ProjectService projectService, TaskService taskService)
        {
            _taskService = taskService;
            _projectService = projectService;
            _workLogService = workLogService;
            WorkLogs = _workLogService.WorkLogs;
        }

        public void ShowLogs(DateTime from, DateTime to)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------\n");
            List<WorkLog> logs = new List<WorkLog>();

            // Create new list of logs
            foreach (var log in WorkLogs)
            {
                if(log.Date >= from && log.Date <= to)
                {
                    logs.Add(log);
                }
            }

            // Show new list of logs
            foreach (var log in logs)
            {
                Console.WriteLine(log);
                Console.WriteLine("--------------------------------------------------\n");
            }
        }

        public void ShowTimeSpentOnProject()
        {
            double sum = 0;
            _projectService.ShowList();
            var projectId = Helpers.GetIntNumber("1. Please enter project Id:");
            var project = _projectService.GetProjectById(projectId);
            Console.Clear();

            if(project != null)
            {
                foreach (var log in WorkLogs)
                {
                    if (log.Project != null && log.Project.Name == project.Name)
                        sum += log.TimeSpent;
                }
                Console.WriteLine("--------------------------------------------------\n");
                Console.WriteLine($"Time spent on project {project.Name} is {sum} hours.\n");
                Console.WriteLine("--------------------------------------------------\n");
            }
            else
                Console.WriteLine("Project not found");
        }

    }
}
