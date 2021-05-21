using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Models
{
    class Dash
    {
        private int noOfRegLecs;
        private int noOfRooms;
        private int noOfStudents;
        private int noOfSubjects;

        private String latestStudent;
        private String latestLecturer;
        private String latestSubjets;

        public int NoOfRegLecs { get => noOfRegLecs; set => noOfRegLecs = value; }
        public int NoOfRooms { get => noOfRooms; set => noOfRooms = value; }
        public int NoOfStudents { get => noOfStudents; set => noOfStudents = value; }
        public int NoOfSubjects { get => noOfSubjects; set => noOfSubjects = value; }
        public string LatestStudent { get => latestStudent; set => latestStudent = value; }
        public string LatestLecturer { get => latestLecturer; set => latestLecturer = value; }
        public string LatestSubjets { get => latestSubjets; set => latestSubjets = value; }
    }
}
