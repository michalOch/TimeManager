using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class TaskService
    {
        public static int counter = 0;
        public List<Task> Tasks { get; set; }

        public TaskService()
        {
            Tasks = new List<Task>();
        }

        public int AddNewTask()
        {
            var id = TaskService.counter + 1;
            var name = Helpers.GetStringValue("1. Please enter new project name:");
            var description = Helpers.GetStringValue("2. Please short describe your project:");
            var estimatedHours = Helpers.GetDoubleNumber("3. Please enter estimated hours for that task:");

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

        public void ShowDetails(int id)
        {
            Task existingTask = null;
            foreach (var task in Tasks)
            {
                if (task.Id == id)
                    existingTask = task;
            }

            if (existingTask != null)
                Console.WriteLine(existingTask);
            else
                Console.WriteLine("Task not found");
        }
    }
}
