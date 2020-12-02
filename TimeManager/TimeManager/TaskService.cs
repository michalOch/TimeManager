using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class TaskService
    {
        // mock value
        public static int counter = 10;
        public List<Task> Tasks { get; set; }

        public TaskService()
        {
            Tasks = new List<Task>();
            CreateMockData();
        }

        public int AddNewTask()
        {
            var id = TaskService.counter + 1;
            var name = Helpers.GetStringValue("1. Please enter new task name:");
            var description = Helpers.GetStringValue("2. Please short describe your task:");
            var estimatedHours = Helpers.GetDoubleNumber("3. Please enter estimated hours for task:");

            Task newTask = new Task()
            {
                Id = id,
                Name = name,
                Description = description,
                EstimatedHours = estimatedHours
            };

            Tasks.Add(newTask);
            counter++;
            return newTask.Id;
        }

        public void Remove(int id)
        {
            Task taskToRemove = null;
            foreach (var task in Tasks)
            {
                if (task.Id == id)
                    taskToRemove = task;
            }
            if (taskToRemove != null)
                Tasks.Remove(taskToRemove);
            else
                Console.WriteLine("Task not found");
        }

        public Task GetTaskById(int id)
        {
            Task existingTask = null;
            foreach (var task in Tasks)
            {
                if (task.Id == id)
                    existingTask = task;
            }
            return existingTask;
        }

        public void ShowDetails(int id)
        {
            Task existingTask = GetTaskById(id);

            if (existingTask != null)
                Console.WriteLine(existingTask);
            else
                Console.WriteLine("Task not found");
        }

        public void ShowAll()
        {
            foreach (var task in Tasks)
            {
                Console.WriteLine(task);
            }
        }
        public void ShowList()
        {
            Console.WriteLine("Avaliable tasks:");
            foreach (var task in Tasks)
            {
                Console.WriteLine($"{task.Id}: {task.Name} ");
            }
            Console.WriteLine("--------------------------------------------------\n");
        }

        public void CreateMockData()
        {
            Tasks = new List<Task>()
            {
                new Task()
                {
                    Id = 1,
                    Name = "Design pedestal",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                    EstimatedHours = 10.0d
                },

                new Task()
                {
                    Id = 2,
                    Name = "Design gripper",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                    EstimatedHours = 20.0d
                },

                new Task()
                {
                    Id = 3,
                    Name = "Design conveyor",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                    EstimatedHours = 30.0d
                },

                new Task()
                {
                    Id = 4,
                    Name = "Design safety fence",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                    EstimatedHours = 10.0d
                },

                new Task()
                {
                    Id = 5,
                    Name = "Design control panel",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                    EstimatedHours = 40.0d
                },

                new Task()
                {
                    Id = 6,
                    Name = "Create electric diagrams",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                    EstimatedHours = 15.5d
                },

                new Task()
                {
                    Id = 7,
                    Name = "Design safety system",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                    EstimatedHours = 23.0d
                },

                new Task()
                {
                    Id = 8,
                    Name = "Create 3D model",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                    EstimatedHours = 10.0d
                },

                new Task()
                {
                    Id = 9,
                    Name = "Create simulation",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                    EstimatedHours = 25.5d
                },

                new Task()
                {
                    Id = 10,
                    Name = "assembly of the robot at the customer's",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                    EstimatedHours = 5.0d
                },

            };
        }
    }
}
