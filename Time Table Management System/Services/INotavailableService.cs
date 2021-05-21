using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    interface INotavailableService
    {
        Boolean addNotavailable(Notavailable notavailable);
        List<Notavailable> getAllNotavailables();
        Notavailable GetNotavailable(int id);
        Boolean deleteNotavailable(int id);  
        List<Notavailable> searchNotavailable(String key, String type);
    }
}
