using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public static class Helpers
    {
        public static void ShowPresences()
        {
            Console.WriteLine("The values of the Presence are:");
            foreach (Presence val in Enum.GetValues(typeof(Presence)))
            {
                if(val != Presence.Undefined)
                {
                    Console.WriteLine($"{(int)val}: {val}");
                }              
            }
            Console.WriteLine("--------------------------------------------------\n");
        }

        public static string GetStringValue(string message)
        {
            string value = string.Empty;
            do
            {
                Console.WriteLine(message);
                value = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(value));

            return value;
        }

        public static double GetDoubleNumber(string message)
        {
            double value = 0.0;
            do
            {
                var stringValue = GetStringValue(message);
                double.TryParse(stringValue, out value);

            } while (value <= 0);
            return value;
        }

        public static int GetIntNumber(string message)
        {
            int value = 0;
            do
            {
                var stringValue = GetStringValue(message);
                int.TryParse(stringValue, out value);
            } while (value <= 0);
            return value;
        }

        public static DateTime GetDate(string message)
        {
            DateTime dateTime;
            do
            {
                var stringValue = GetStringValue(message);
                DateTime.TryParse(stringValue, out dateTime);
            } while (dateTime == null);
            return dateTime;
        }

        public static void CreateMenu(string menuName, MenuActionService actionService)
        {
            Console.WriteLine("Please let me know what you want to do: \n");
            var mainMenu = actionService.GetMenuActionsByMenuName(menuName);
            for (int i = 0; i < mainMenu.Count; i++)
            {
                Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
            }
        }

        public static MenuActionService Initialize(MenuActionService actionService)
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
