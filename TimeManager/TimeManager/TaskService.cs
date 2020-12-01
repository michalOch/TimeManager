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
    }
}
