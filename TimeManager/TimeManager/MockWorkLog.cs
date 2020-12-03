using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class MockWorkLog
    {
        
        private ProjectService _projectService;
        private TaskService _taskService;

        public MockWorkLog(ProjectService projectService, TaskService taskService)
        {
            _projectService = projectService;
            _taskService = taskService;
        }

        public List<WorkLog> CreateMockData()
        {
            List<WorkLog> WorkLogs = new List<WorkLog>(); 

            WorkLogs = new List<WorkLog>()
            {
                // 2020-11

                new WorkLog()
                {
                    Id = 1,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[1],
                    Date = new DateTime(2020,11,1),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 2,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[1],
                    Date = new DateTime(2020,11,2),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 3,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[2],
                    Date = new DateTime(2020,11,3),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 4,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[2],
                    Date = new DateTime(2020,11,4),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 5,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[3],
                    Date = new DateTime(2020,11,5),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 6,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[3],
                    Date = new DateTime(2020,11,6),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 7,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[4],
                    Date = new DateTime(2020,11,7),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 8,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[4],
                    Date = new DateTime(2020,11,8),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 9,
                    Project = null,
                    Task = null,
                    Date = new DateTime(2020,11,9),
                    Presence = Presence.SickLeave,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 10,
                    Project = null,
                    Task = null,
                    Date = new DateTime(2020,11,10),
                    Presence = Presence.SickLeave,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 11,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[5],
                    Date = new DateTime(2020,11,11),
                    Presence = Presence.Delegation,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 12,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[5],
                    Date = new DateTime(2020,11,12),
                    Presence = Presence.Delegation,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 13,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[6],
                    Date = new DateTime(2020,11,13),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 14,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[6],
                    Date = new DateTime(2020,11,14),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 15,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[7],
                    Date = new DateTime(2020,11,15),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 16,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[7],
                    Date = new DateTime(2020,11,16),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 17,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[8],
                    Date = new DateTime(2020,11,17),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 18,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[8],
                    Date = new DateTime(2020,11,18),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 19,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[8],
                    Date = new DateTime(2020,11,19),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 20,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[9],
                    Date = new DateTime(2020,11,20),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 21,
                    Project = _projectService.Projects[0],
                    Task = _taskService.Tasks[9],
                    Date = new DateTime(2020,11,21),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                //---------------------------------------------------------------------------------------------------------------------------------------------
                // 2020-12

                new WorkLog()
                {
                    Id = 22,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[1],
                    Date = new DateTime(2020,12,1),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 23,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[1],
                    Date = new DateTime(2020,12,2),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 24,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[2],
                    Date = new DateTime(2020,12,3),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 25,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[2],
                    Date = new DateTime(2020,12,4),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 26,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[3],
                    Date = new DateTime(2020,12,5),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 27,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[3],
                    Date = new DateTime(2020,12,6),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 28,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[4],
                    Date = new DateTime(2020,12,7),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 29,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[4],
                    Date = new DateTime(2020,12,8),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 30,
                    Project = null,
                    Task = null,
                    Date = new DateTime(2020,12,8),
                    Presence = Presence.SickLeave,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 31,
                    Project = null,
                    Task = null,
                    Date = new DateTime(2020,12,9),
                    Presence = Presence.SickLeave,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 32,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[5],
                    Date = new DateTime(2020,12,11),
                    Presence = Presence.Delegation,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 33,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[5],
                    Date = new DateTime(2020,12,12),
                    Presence = Presence.Delegation,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 34,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[6],
                    Date = new DateTime(2020,12,13),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 35,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[6],
                    Date = new DateTime(2020,12,14),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 36,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[7],
                    Date = new DateTime(2020,12,15),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 37,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[7],
                    Date = new DateTime(2020,12,16),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 38,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[8],
                    Date = new DateTime(2020,12,17),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 39,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[8],
                    Date = new DateTime(2020,12,18),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 40,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[8],
                    Date = new DateTime(2020,12,19),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },

                new WorkLog()
                {
                    Id = 41,
                    Project = _projectService.Projects[1],
                    Task = _taskService.Tasks[9],
                    Date = new DateTime(2020,12,20),
                    Presence = Presence.Present,
                    TimeSpent = 8,
                    Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                },
            };

            return WorkLogs;
        }
    }
}
