using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    interface IConsecRoomService
    {
        Boolean addConsecutive(int con_id,ConsecRoom room);
        List<ConsecRoom> getAllConsecutives();
        ConsecRoom GetConsecutive(int id);
        Boolean deleteConsecutive(int id);
        Boolean updateConsecutive(int id, Consecutive consecutive);
        List<Consecutive> searchConsecutive(String key, String type);
    }
}
