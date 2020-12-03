using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class ReportService
    {
        private readonly WorkLogService workLogService;

        public ReportService(WorkLogService workLogService)
        {
            this.workLogService = workLogService;
        }


    }
}
