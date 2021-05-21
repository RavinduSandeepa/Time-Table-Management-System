using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    interface IStudentService
    {
        Boolean addStudent(Student student);
        List<Student> getAllStudents();
        Student GetStudent(int id);
        Boolean deleteStudent(int id);
        Boolean updateStudent(int id, Student student);


    }
}
