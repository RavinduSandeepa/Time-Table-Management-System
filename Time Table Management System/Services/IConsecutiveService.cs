using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    interface IConsecutiveService
    {
        Boolean addConsecutive(int conSessionID1, int conSessionID2);
        List<Consecutive> getAllConsecutives();
        Consecutive GetConsecutive(int id);
        Boolean deleteConsecutive(int id);
        Boolean updateConsecutive(int id, Consecutive consecutive);
        List<Consecutive> searchConsecutive(String key, String type);
    }

 
}
