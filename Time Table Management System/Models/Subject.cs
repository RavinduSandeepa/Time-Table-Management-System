using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Models
{
    class Subject
    {
        private int id;
        private String subjectName;
        private String subjectCode;
        private int offeredYear;
        private int offeredSem;
        private int lecHours;
        private int tuteHours;
        private int labHours;
        private int evaluationHours;

        public string SubjectName { get => subjectName; set => subjectName = value; }
        public string SubjectCode { get => subjectCode; set => subjectCode = value; }
        public int OfferedYear { get => offeredYear; set => offeredYear = value; }
        public int OfferedSem { get => offeredSem; set => offeredSem = value; }
        public int LecHours { get => lecHours; set => lecHours = value; }
        public int TuteHours { get => tuteHours; set => tuteHours = value; }
        public int LabHours { get => labHours; set => labHours = value; }
        public int EvaluationHours { get => evaluationHours; set => evaluationHours = value; }
        public int Id { get => id; set => id = value; }
    }
}
