using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Models
{
    class Lecturer
    {
        private String name;
        private String employeeID;
        private String faculty;
        private String department;
        private String center;
        private String building;
        private int level;
        private String rank;
        private int id;

        public string Name { get => name; set => name = value; }
        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public string Department { get => department; set => department = value; }
        public string Center { get => center; set => center = value; }
        public string Building { get => building; set => building = value; }
        public int Level { get => level; set => level = value; }
        public string Rank { get => rank; set => rank = value; }
        public int Id { get => id; set => id = value; }
    }
}
