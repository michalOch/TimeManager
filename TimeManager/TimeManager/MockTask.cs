using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class MockTask
    {
        public List<Task> GetMockData()
        {
            List<Task> Tasks = new List<Task>()
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

            return Tasks;
        }
    }
}
