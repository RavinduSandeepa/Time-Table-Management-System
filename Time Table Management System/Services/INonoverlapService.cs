using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    interface INonoverlapService
    {
        Boolean addNonoverlap(int nonSessionID1, int nonSessionID2, int nonSessionID3, int nonSessionID4);
        List<Nonoverlap> getAllNonoverlaps();
        Nonoverlap GetNonoverlap(int id);
        Boolean deleteNonoverlap(int id);
        Boolean updateNonoverlap(int id, Nonoverlap nonoverlap);
        List<Nonoverlap> searchNonoverlap(String key, String type);
    }
}
