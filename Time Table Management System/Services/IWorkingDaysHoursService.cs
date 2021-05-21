using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    interface IWorkingDaysHoursService
    {
        Boolean addWorkingDaysHours(WorkingDaysHours workingDaysHours);
        WorkingDaysHours getWorkingDaysHours();
        Boolean updateWorkingDaysHours(WorkingDaysHours workingDaysHours);
        Boolean getExistWorkingDaysHours();
        Boolean deleteWorkingDaysHours();
    }
}
