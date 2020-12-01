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
                                    Console.WriteLine("Update");
                                    Console.ReadKey();
                                    break;

                                case '4':
                                    Console.Clear();
                                    var projectId = Helpers.GetIntNumber("Please enter project id");
                                    projectService.GetProjectDetails(projectId);
                                    Console.WriteLine("Press any key to go back...");
                                    Console.ReadKey();
                                    break;

                                case '5':
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


            //  1.2 Modyfikacja projektu
            //      1.2.1 Wprowadzenie Id lub nazwy projektu
            //      1.2.2 Wyświetlenie szczegółow projektu
            //      1.2.3 Wyświetlenie wyboru rzeczy do modyfikacji 
            //              1 - Nazwa
            //              2 - Numer SAP
            //              3 - Opis projektu 
            //              4 - Stan (Enum - Projektowanie, Składanie, Uruchomienie, Testy)
            //              5 - Wróć
            //      1.2.4 - W zależności od wyboru uzupełniamy dane pole

            //  1.3 Usunięcie projektu (i związanych z nim tasków)
            //      1.3.1 Wprowadzenie Id lub nazwy projektu
            //      1.3.2 Usunięcie danego projektu razem z należącymi do niego stanami

            //  1.4 Szczególy danego projektu
            //      1.4.1 Wprowadzenie Id lub nazwy projektu
            //      1.4.2 Wyświetlenie Nazwy, Numeru Sap, i obecnego stanu projektu 

            //  1.5 Lista wszystkich projektów z taskami do tych projektów
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

            //  2.2 Modyfikacja zadania
            //      2.2.1 Wprowadzenie Id zadania            
            //      2.2.2 Wyświetlenie szczegółow zadania
            //      2.2.3 Wyświetlenie wyboru rzeczy do modyfikacji 
            //              1 - Projekt
            //              2 - Nazwa
            //              3 - Opis 
            //              4 - Estymacja godzin
            //              5 - Stan (Nowe, Aktywne, Zamknięte - new, active, closed)
            //              6 - Wróć
            //      2.2.4 - W zależności od wyboru uzupełniamy dane pole

            //  2.3 Usunięcie zadania
            //      2.3.1 Wprowadzenie Id zadania            
            //      2.3.2 Usunięcie zadania o wskazanym Id

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

            //  3.3 Modyfikuj dany wpis
            //      3.3.1 Wprowadzenie Id wpisu            
            //      3.3.2 Wyświetlenie szczegółow wpisu
            //      3.3.3 Wyświetlenie wyboru rzeczy do modyfikacji 
            //              1 - Projekt
            //              2 - Zadanie
            //              3 - Datę 
            //              4 - Obecność
            //              5 - Czas spędzony na zadaniu
            //              6 - Komentarz
            //              7 - Wróc
            
            //      3.3.4 - W zależności od wyboru uzupełniamy dane pole

            //  3.4 Pokaż wszystkie wpisy dla danego projektu
            //  3.5 Pokaż wszystkie wpisy dla danego zadania
            //  3.6 Pokaż wszystkie wpisy dla danego projektu

            // 4. Raporty
            //  4.1 Ilosć godzin per projekt
            //  4.2 Ilość godzin per okres czasu (np. w danym miesiącu)
            //  4.3 Róznice między estymacją a wykonaniem zadania - do oceny efektywnośći pracownika itp.
            //  4.4 Projekty i taski
            //  4.5 Projekty i task i podsumowanie szczegółowe
            //  4.6 Taski w projekcie procentowo

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
            actionService.AddNewAction(3, "Update project", "Project");
            actionService.AddNewAction(4, "Details", "Project");
            actionService.AddNewAction(5, "Exit", "Project");

            actionService.AddNewAction(1, "ExternalId", "ProjectUpdate");
            actionService.AddNewAction(2, "Name", "ProjectUpdate");
            actionService.AddNewAction(3, "Description", "ProjectUpdate");
            actionService.AddNewAction(4, "State", "ProjectUpdate");
            actionService.AddNewAction(5, "Exit", "ProjectUpdate");

            actionService.AddNewAction(1, "Add new task", "Task");
            actionService.AddNewAction(2, "Remove task", "Task");
            actionService.AddNewAction(3, "Update task", "Task");
            actionService.AddNewAction(4, "Details", "Task");
            actionService.AddNewAction(5, "Exit", "Task");

            actionService.AddNewAction(1, "Name", "TaskUpdate");
            actionService.AddNewAction(2, "Description", "TaskUpdate");
            actionService.AddNewAction(3, "EstimatedHours", "TaskUpdate");
            actionService.AddNewAction(4, "Exit", "TaskUpdate");

            actionService.AddNewAction(1, "Add new log", "Worklog");
            actionService.AddNewAction(2, "Remove log", "Worklog");
            actionService.AddNewAction(3, "Update log", "Worklog");
            actionService.AddNewAction(4, "Details", "Worklog");
            actionService.AddNewAction(5, "Exit", "Worklog");

            actionService.AddNewAction(1, "Project", "WorklogUpdate");
            actionService.AddNewAction(2, "Task", "WorklogUpdate");
            actionService.AddNewAction(3, "Date from", "WorklogUpdate");
            actionService.AddNewAction(4, "Date to", "WorklogUpdate");
            actionService.AddNewAction(5, "Presence", "WorklogUpdate");
            actionService.AddNewAction(6, "Time spent", "WorklogUpdate");
            actionService.AddNewAction(7, "Comment", "WorklogUpdate");
            actionService.AddNewAction(8, "Exit", "WorklogUpdate");

            return actionService;
        }

    }
}
