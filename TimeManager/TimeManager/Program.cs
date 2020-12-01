﻿using System;
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
            WorkLogService workLogService = new WorkLogService();
            var repeat = true;
            Console.WriteLine("Welcome to the Time Managment App");

            while(repeat)
            {
                Console.WriteLine("Please let me know what you want to do: ");
                var mainMenu = actionService.GetMenuActionsByMenuName("Main");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                }

                var operation = Console.ReadKey();
                Console.WriteLine("------------------------------------");
                switch (operation.KeyChar)
                {
                    case '1':
                        bool repatProject = true;
                        while(repatProject)
                        {
                            Console.Clear();
                            Console.WriteLine("Please let me know what you want to do: ");
                            var projectMenu = actionService.GetMenuActionsByMenuName("Project");
                            for (int i = 0; i < projectMenu.Count; i++)
                            {
                                Console.WriteLine($"{projectMenu[i].Id}. {projectMenu[i].Name}");
                            }
                            var projectOperation = Console.ReadKey();

                            Console.WriteLine("------------------------------------");
                            switch (projectOperation.KeyChar)
                            {
                                case '1':
                                    Console.Clear();
                                    var id = projectService.AddNewProject();
                                    Console.Clear();
                                    Console.WriteLine($"You have create new project with id: {id}");
                                    Thread.Sleep(1000);
                                    break;

                                case '2':
                                    Console.Clear();
                                    Console.WriteLine("Remove");
                                    Console.ReadKey();
                                    break;

                                case '3':
                                    Console.Clear();
                                    var projectId = Helpers.GetIntNumber("Please enter project id");
                                    projectService.GetProjectDetails(projectId);
                                    Console.WriteLine("Press any key to go back...");
                                    Console.ReadKey();
                                    break;

                                case '4':
                                    Console.Clear();
                                    Console.WriteLine("Closing...");
                                    repatProject = false;
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
                        Console.Clear();
                        Console.WriteLine("Tasks operations");
                        break;

                    case '3':
                        Console.Clear();
                        Console.WriteLine("Worklogs operations");
                        break;

                    case '4':
                        Console.Clear();
                        Console.WriteLine("Generating reports");
                        break;

                    case '5':
                        Console.Clear();
                        Console.WriteLine("Close application");
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


            //  1.2 Usunięcie projektu (i związanych z nim tasków)
            //      1.3.1 Wprowadzenie Id lub nazwy projektu
            //      1.3.2 Usunięcie danego projektu razem z należącymi do niego stanami

            //  1.3 Szczególy danego projektu
            //      1.4.1 Wprowadzenie Id lub nazwy projektu
            //      1.4.2 Wyświetlenie Nazwy, Numeru Sap, i obecnego stanu projektu 

            //  1.4 Lista wszystkich projektów 
            //      1.5.1 Wprowadzenie Id lub nazwy projektu
            //      1.5.2 Wyświetlenie listy projektów wraz z taskami (listą tasków)



            // 2. Operacja na zadaniach (Task)
            //  2.1 Tworzenie nowego zadania do danego projektu
            //      2.1.1 Wprowadzenie nazwy projektu
            //      2.1.1 Wprowadzenie nazwy zadania
            //      2.1.2 Wprowadzenie opisu zadania
            //      2.1.3 Wprowadzenie estymacji godzin dla zadania
            //      2.1.4 Stan zadania ustalony inicjalnie na nowe 
            //      2.1.5 Zwrócenie Id taska i wyświetlenie podsumowania

            //  2.2 Usunięcie zadania
            //      2.3.1 Wprowadzenie Id zadania            
            //      2.3.2 Usunięcie zadania o wskazanym Id

            //  2.3 Szczególy danego zadania
            //      1.4.1 Wprowadzenie Id lub nazwy projektu
            //      1.4.2 Wyświetlenie szczegółow zadania 

            //  2.4 Lista wszystkich tasków dla danego id projektu 
            //      1.5.1 Wprowadzenie Id lub nazwy projektu
            //      1.5.2 Wyświetlenie listy tasków dla danego projektu


            // 3. Operacje na wpisach godzinowych (WorkLog)
            //  3.1 Dodaj nowy wpis
            //      3.1.1 Wybierz Projekt
            //      3.1.2 Wybierz Zadanie
            //      3.1.3 Wybierz Datę
            //      3.1.4 Wybierz Obecność(Present, Absent, Remote, Delegation, On Holiday, Sick Leave)
            //      3.1.5 Czas spędzony (Time Spent)
            //      3.1.6 Komentrz
            //      3.1.7 Wyświetl podsumowanie wpisanych danych
            //      3.1.8 Zwróć Id zadania

            //  3.2 Usuń dany wpisu
            //      3.2.1 Wprowadzenie Id wpisu 
            //      3.2.2 Usuń dany wpis

            //  3.3 Szczególy danego wpisu
            //      1.4.1 Wprowadzenie Id wpisu
            //      1.4.2 Wyświetlenie szczegółow zadania 

            //  3.4 Lista wszystkich wpisów dla danego projektu
            //      1.5.1 Wprowadzenie Id lub nazwy projektu
            //      1.5.2 Wyświetlenie listy wpisów

            //  3.5 Lista wszystkich wpisów dla danego zadania
            //      1.5.1 Wprowadzenie Id zadania
            //      1.5.2 Wyświetlenie listy wpisów


            // 4. Raporty

            //  4.1 Wyświetlnie wpisów dla danego miesiąca

            //  4.2 Ilość godzin przepracowna w danym miesiacu (w zadanym okresie czasu)
            //  4.2 Wypłata netto dla danego miesiaca (double stawka godzinowa)

            //  4.3 Ilość godzin przepracowna nad danym projektem (id projektu)
            //  4.4 Lista wszystkich wpisów dla danego projektu

            //  4.5 Ilość godzin przepracowna nad danym zadaniem 
            //  4.4 Lista wszystkich wpisów dla danego zadania


            // 5. Zamknij
        }

        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Projects", "Main");
            actionService.AddNewAction(2, "Tasks", "Main");
            actionService.AddNewAction(3, "WorkLogs", "Main");
            actionService.AddNewAction(4, "Reports", "Main");
            actionService.AddNewAction(5, "Exit", "Main");

            actionService.AddNewAction(1, "Add new project", "Project");
            actionService.AddNewAction(2, "Remove project", "Project");
            actionService.AddNewAction(3, "Details", "Project");
            actionService.AddNewAction(4, "Exit", "Project");

            actionService.AddNewAction(1, "Add new task", "Task");
            actionService.AddNewAction(2, "Remove task", "Task");
            actionService.AddNewAction(3, "Details", "Task");
            actionService.AddNewAction(4, "Exit", "Task");

            actionService.AddNewAction(1, "Add new log", "Worklog");
            actionService.AddNewAction(2, "Remove log", "Worklog");
            actionService.AddNewAction(3, "Details", "Worklog");
            actionService.AddNewAction(4, "Exit", "Worklog");

            actionService.AddNewAction(1, "Worklogs per month", "Report");
            actionService.AddNewAction(2, "Hours and salary per month", "Report");
            actionService.AddNewAction(3, "Time spent on project", "Report");
            actionService.AddNewAction(4, "Worklogs per project", "Report");
            actionService.AddNewAction(5, "Time spent on task", "Report");
            actionService.AddNewAction(6, "Worklogs per task", "Report");
            actionService.AddNewAction(7, "Exit", "Report");

            return actionService;
        }

    }
}
