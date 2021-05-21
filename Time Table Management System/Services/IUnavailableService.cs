using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    interface IUnavailableService
    {
        Boolean addUnavailable(Unavailable unavailable);
        List<Unavailable> getAllUnavailable();
        Unavailable GetUnavailable(int id);
        Boolean deleteUnavailable(int id);
        Boolean updateUnavailable(int id,Unavailable unavailable);



    }
}
