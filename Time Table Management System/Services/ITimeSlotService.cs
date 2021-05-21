using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    interface ITimeSlotService
    {
        Boolean addTimeSlots(TimeSlot timeSlot);

        List<TimeSlot> getAllTimeSlots();

        TimeSlot getTimeSlot(int id);

        Boolean deleteTimeSlot(int id);
    }
}
