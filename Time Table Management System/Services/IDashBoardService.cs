using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    interface IDashBoardService
    {
        int getStudentsCount();
        int getLecturersCount();
        int getLocationsCount();
        int getSubjectsCount();
        string getLatestGroupName();
        string getLatestLecturer();
        string getLatestSubject();
        int getLecCount();
        int getLabCount();
    }
}
