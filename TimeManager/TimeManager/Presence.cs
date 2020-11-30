using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public enum  Presence
    {
        Undefined = 0,
        Present,
        Absent,
        Remote,
        Delegation,
        OnHoliday,
        SickLeave
    }
}
