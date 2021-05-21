using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    interface ILecturerService
    {
        Boolean addLecturer(Lecturer lecturer); 
        List<Lecturer> getAllLecturers();
        Lecturer GetLecturer(int id);
        Boolean deleteLecturer(int id);
        Boolean updateLecturer(int id, Lecturer lecturer);
    }
}
