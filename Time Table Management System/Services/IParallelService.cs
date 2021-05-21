using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    interface IParallelService
    {
        Boolean addParallel(int parSessionID1, int parSessionID2, int parSessionID3);
        List<ParalleDTO> getAllParallels();
        ParalleDTO GetParallel(int id);
        Boolean deleteParallel(int id);
        Boolean updateParallel(int id, ParalleDTO parallel);
        List<ParalleDTO> searchParallel(String key, String type);

    }
}
