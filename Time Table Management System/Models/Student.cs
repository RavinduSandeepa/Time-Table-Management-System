using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Models
{
    class Student
    {
        private int id;
        private String academicYear;
        private String programme;
        private int groupNumber;
        private String groupId;
        private int subGroupNumber;
        private String subGroupId;

        public int Id { get => id; set => id = value; }
        public string AcademicYear { get => academicYear; set => academicYear = value; }
        public string Programme { get => programme; set => programme = value; }
        public int GroupNumber { get => groupNumber; set => groupNumber = value; }
        public string GroupId { get => groupId; set => groupId = value; }
        public int SubGroupNumber { get => subGroupNumber; set => subGroupNumber = value; }
        public string SubGroupId { get => subGroupId; set => subGroupId = value; }
        
    }
}
