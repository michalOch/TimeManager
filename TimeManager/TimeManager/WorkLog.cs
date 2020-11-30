using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class WorkLog
    {
        public int Id { get; set; }
        public Project Project { get; set; }
        public Task Task { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public Presence Presence { get; set; }
        public double TimeSpent { get; set; }
    }
}
