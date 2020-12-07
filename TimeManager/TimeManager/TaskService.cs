using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class TaskService
    {
        private MockTask mockTask;

        public static int counter = 10;
        public List<Task> Tasks { get; set; }

        public TaskService()
        {
            Tasks = new List<Task>();
            mockTask = new MockTask();
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
            Tasks = mockTask.GetMockData();
        }
    }
}
