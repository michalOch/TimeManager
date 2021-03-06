﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class MockProject
    {
        public List<Project> GetMockData()
        {
            List<Project> Projects;

            Projects = new List<Project>()
            {
                new Project()
                {
                    Id = 1,
                    Name = "Sapa",
                    ExternalId = "00000001",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Proin sed libero enim sed faucibus turpis in eu mi. Lacus sed viverra tellus in hac habitasse platea dictumst. Consectetur purus ut faucibus pulvinar elementum integer enim neque. "
                },
                new Project()
                {
                    Id = 2,
                    Name = "Andersen Steel",
                    ExternalId = "00000002",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Proin sed libero enim sed faucibus turpis in eu mi. Lacus sed viverra tellus in hac habitasse platea dictumst. Consectetur purus ut faucibus pulvinar elementum integer enim neque. "
                },
                new Project()
                {
                    Id = 3,
                    Name = "Lubella",
                    ExternalId = "00000003",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Proin sed libero enim sed faucibus turpis in eu mi. Lacus sed viverra tellus in hac habitasse platea dictumst. Consectetur purus ut faucibus pulvinar elementum integer enim neque. "
                },
                new Project()
                {
                    Id = 4,
                    Name = "Volkswagen",
                    ExternalId = "00000004",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Proin sed libero enim sed faucibus turpis in eu mi. Lacus sed viverra tellus in hac habitasse platea dictumst. Consectetur purus ut faucibus pulvinar elementum integer enim neque. "
                },
                new Project()
                {
                    Id = 5,
                    Name = "Bella",
                    ExternalId = "00000005",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Proin sed libero enim sed faucibus turpis in eu mi. Lacus sed viverra tellus in hac habitasse platea dictumst. Consectetur purus ut faucibus pulvinar elementum integer enim neque. "
                },
                new Project()
                {
                    Id = 6,
                    Name = "Jabil",
                    ExternalId = "00000006",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Proin sed libero enim sed faucibus turpis in eu mi. Lacus sed viverra tellus in hac habitasse platea dictumst. Consectetur purus ut faucibus pulvinar elementum integer enim neque. "
                },
                new Project()
                {
                    Id = 7,
                    Name = "Zentex",
                    ExternalId = "00000007",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Proin sed libero enim sed faucibus turpis in eu mi. Lacus sed viverra tellus in hac habitasse platea dictumst. Consectetur purus ut faucibus pulvinar elementum integer enim neque. "
                },
            };

            return Projects;
        }
    }
}
