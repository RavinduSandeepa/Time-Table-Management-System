using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    interface ISubjectService
    {
        Boolean addSubject(Subject subject);
        List<Subject> getAllSubjects();
        Subject getSubject(int id);

        Boolean deleteSubject(int id);

        Boolean updateSubject(int id, Subject subject);
    }
}
