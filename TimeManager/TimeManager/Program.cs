using System;
using System.Threading;

namespace TimeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);
            ProjectService projectService = new ProjectService();
            TaskService taskService = new TaskService();
            WorkLogService workLogService = new WorkLogService(projectService, taskService);
            ReportService reportService = new ReportService(workLogService,projectService, taskService);

            var repeat = true;
            Console.WriteLine("Welcome to the Time Managment App\n");

            while(repeat)
            {
                //Console.WriteLine("Please let me know what you want to do: \n");
                //var mainMenu = actionService.GetMenuActionsByMenuName("Main");
                //for (int i = 0; i < mainMenu.Count; i++)
                //{
                //    Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                //}

                Helpers.CreateMenu("Main", actionService);

                var operation = Console.ReadKey();
                Console.WriteLine("------------------------------------");
                switch (operation.KeyChar)
                {
                    case '1':
                        bool repeatProject = true;
                        while(repeatProject)
                        {
                            Console.Clear();
                            //Console.WriteLine("Please let me know what you want to do: \n");
                            //var projectMenu = actionService.GetMenuActionsByMenuName("Project");
                            //for (int i = 0; i < projectMenu.Count; i++)
                            //{
                            //    Console.WriteLine($"{projectMenu[i].Id}. {projectMenu[i].Name}");
                            //}

                            Helpers.CreateMenu("Project", actionService);

                            var projectOperation = Console.ReadKey();

                            Console.WriteLine("------------------------------------");
                            switch (projectOperation.KeyChar)
                            {
                                case '1':
                                    Console.Clear();
                                    var id = projectService.AddNewProject();
                                    Console.Clear();
                                    Console.WriteLine($"You have successfully create new project with id: {id}");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    break;

                                case '2':
                                    Console.Clear();
                                    var projectIdToRemove = Helpers.GetIntNumber("Please enter project id");
                                    projectService.Remove(projectIdToRemove);
                                    Console.WriteLine($"Project with id: {projectIdToRemove} has been successfully removed");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    break;

                                case '3':
                                    Console.Clear();
                                    var projectIdToShow = Helpers.GetIntNumber("Please enter project id");
                                    projectService.ShowDetails(projectIdToShow);
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    break;

                                case '4':
                                    Console.Clear();
                                    projectService.ShowAll();
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    break;

                                case '5':
                                    Console.Clear();
                                    repeatProject = false;
                                    Console.Clear();
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine("You have chosen wrong operation");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    break;
                            }
                        }
                        break;

                    case '2':
                        bool repeatTask = true;
                        while (repeatTask)
                        {
                            Console.Clear();
                            //Console.WriteLine("Please let me know what you want to do: \n");
                            //var taskMenu = actionService.GetMenuActionsByMenuName("Task");
                            //for (int i = 0; i < taskMenu.Count; i++)
                            //{
                            //    Console.WriteLine($"{taskMenu[i].Id}. {taskMenu[i].Name}");
                            //}
                            Helpers.CreateMenu("Task", actionService);
                            var taskOeration = Console.ReadKey();

                            Console.WriteLine("------------------------------------");
                            switch (taskOeration.KeyChar)
                            {
                                case '1':
                                    Console.Clear();
                                    var id = taskService.AddNewTask();
                                    Console.Clear();
                                    Console.WriteLine($"You have successfully create new task with id: {id}");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    break;

                                case '2':
                                    Console.Clear();
                                    var taskIdToRemove = Helpers.GetIntNumber("Please enter task id");
                                    taskService.Remove(taskIdToRemove);
                                    Console.WriteLine($"Task with id: {taskIdToRemove} has been successfully removed");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    break;

                                case '3':

                                    Console.Clear();
                                    var taskIdToShow = Helpers.GetIntNumber("Please enter task id");
                                    taskService.ShowDetails(taskIdToShow);
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    break;

                                case '4':

                                    Console.Clear();
                                    taskService.ShowAll();
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    break;

                                case '5':
                                    Console.Clear();
                                    repeatTask = false;
                                    Console.Clear();
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine("You have chosen wrong operation");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    break;
                            }
                        }
                        break;

                    case '3':
                        bool repeatLog = true;
                        while (repeatLog)
                        {
                            Console.Clear();
                            //Console.WriteLine("Please let me know what you want to do: \n");
                            //var worklogMenu = actionService.GetMenuActionsByMenuName("Worklog");
                            //for (int i = 0; i < worklogMenu.Count; i++)
                            //{
                            //    Console.WriteLine($"{worklogMenu[i].Id}. {worklogMenu[i].Name}");
                            //}

                            Helpers.CreateMenu("Worklog", actionService);
                            var projectOperation = Console.ReadKey();

                            Console.WriteLine("------------------------------------");
                            switch (projectOperation.KeyChar)
                            {
                                case '1':
 
                                    Console.Clear();
                                    var id = workLogService.AddNewLog(true);
                                    Console.Clear();
                                    Console.WriteLine($"You have successfully create new worklog with id: {id}");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    break;

                                case '2':
                                    Console.Clear();
                                    var logIdToRemove = Helpers.GetIntNumber("Please enter worklog id");
                                    workLogService.Remove(logIdToRemove);
                                    Console.WriteLine($"Worklog with id: {logIdToRemove} has been successfully removed");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    break;

                                case '3':

                                    Console.Clear();
                                    var logIdToShow = Helpers.GetIntNumber("Please enter worklog id");
                                    workLogService.ShowDetails(logIdToShow);
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    break;

                                case '4':

                                    Console.Clear();
                                    workLogService.ShowAll();
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    break;

                                case '5':
                                    Console.Clear();
                                    repeatLog = false;
                                    Console.Clear();
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine("You have chosen wrong operation");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    break;
                            }
                        }
                        break;

                    case '4':
                        bool repeatReports = true;
                        while (repeatReports)
                        {
                            Console.Clear();
                            //Console.WriteLine("Please let me know what you want to do: \n");
                            //var reportsMenu = actionService.GetMenuActionsByMenuName("Report");
                            //for (int i = 0; i < reportsMenu.Count; i++)
                            //{
                            //    Console.WriteLine($"{reportsMenu[i].Id}. {reportsMenu[i].Name}");
                            //}
                            Helpers.CreateMenu("Report", actionService);
                            var reportOperation = Console.ReadKey();

                            Console.WriteLine("------------------------------------");
                            switch (reportOperation.KeyChar)
                            {
                                case '1':

                                    Console.Clear();
                                    DateTime from = Helpers.GetDate("Please enter timesheet start time (yyyy-mm-dd): ");
                                    DateTime to = Helpers.GetDate("Please enter timesheet end time (yyyy-mm-dd): ");
                                    reportService.ShowLogs(from, to);
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    break;

                                case '2':

                                    Console.Clear();
                                    reportService.ShowTimeSpentOnProject();
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    break;

                                case '3':

                                    Console.Clear();
                                    reportService.ShowTimeSpentOnTask();
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    break;

                                case '4':

                                    Console.Clear();
                                    reportService.ShowLogsOnProject();
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    break;

                                case '5':

                                    Console.Clear();
                                    reportService.ShowLogsOnTask();
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    break;

                                case '6':
                                    Console.Clear();
                                    repeatReports = false;
                                    Console.Clear();
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine("You have chosen wrong operation");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    break;
                            }
                        }
                        break;

                    case '5':
                        Console.Clear();
                        repeat = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("You have chosen wrong operation");
                        Thread.Sleep(500);
                        Console.Clear();
                        break;
                }
            }
        }

        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Operation on Projects", "Main");
            actionService.AddNewAction(2, "Operation on Tasks", "Main");
            actionService.AddNewAction(3, "Operation on WorkLogs", "Main");
            actionService.AddNewAction(4, "Generating Reports", "Main");
            actionService.AddNewAction(5, "Close", "Main");

            actionService.AddNewAction(1, "Add new project", "Project");
            actionService.AddNewAction(2, "Remove project", "Project");
            actionService.AddNewAction(3, "Show project details", "Project");
            actionService.AddNewAction(4, "Show all projects", "Project");
            actionService.AddNewAction(5, "Return", "Project");

            actionService.AddNewAction(1, "Add new task", "Task");
            actionService.AddNewAction(2, "Remove task", "Task");
            actionService.AddNewAction(3, "Show task details", "Task");
            actionService.AddNewAction(4, "Show all tasks", "Task");
            actionService.AddNewAction(5, "Return", "Task");

            actionService.AddNewAction(1, "Add new log", "Worklog");
            actionService.AddNewAction(2, "Remove log", "Worklog");
            actionService.AddNewAction(3, "Show log details", "Worklog");
            actionService.AddNewAction(4, "Show all logs", "Worklog");
            actionService.AddNewAction(5, "Return", "Worklog");

            actionService.AddNewAction(1, "Show worklogs in time interval", "Report");
            actionService.AddNewAction(2, "Show time spent on project", "Report");
            actionService.AddNewAction(3, "Show time spent on task", "Report");
            actionService.AddNewAction(4, "Show logs on project", "Report");
            actionService.AddNewAction(5, "Show logs on task", "Report");
            actionService.AddNewAction(6, "Return", "Report");

            return actionService;
        }

    }
}
