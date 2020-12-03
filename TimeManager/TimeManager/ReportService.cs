using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class ReportService
    {
        private  WorkLogService _workLogService;
        private List<WorkLog> WorkLogs;

        public ReportService(WorkLogService workLogService)
        {
            _workLogService = workLogService;
            WorkLogs = _workLogService.WorkLogs;
        }

        public void ShowLogs(DateTime from, DateTime to)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------\n");
            List<WorkLog> logs = new List<WorkLog>();

            // Create new list of logs
            foreach (var log in WorkLogs)
            {
                if(log.Date >= from && log.Date <= to)
                {
                    logs.Add(log);
                }
            }

            // Show new list of logs
            foreach (var log in logs)
            {
                Console.WriteLine(log);
                Console.WriteLine("--------------------------------------------------\n");
            }
        }

    }
}
