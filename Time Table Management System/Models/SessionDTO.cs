using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Models
{
    class SessionDTO
    {
        private int id;
        private int lec1_id;
        private String lec1_name;
        private int lec2_id;
        private String lec2_name;
        private String subject_code;
        private String subject_name;
        private String tag;
        private String group_code;
        private int student_count;
        private int duration;
        private String room;

        public int Id { get => id; set => id = value; }
        public int Lec1_id { get => lec1_id; set => lec1_id = value; }
        public string Lec1_name { get => lec1_name; set => lec1_name = value; }
        public int Lec2_id { get => lec2_id; set => lec2_id = value; }
        public string Lec2_name { get => lec2_name; set => lec2_name = value; }
        public string Subject_code { get => subject_code; set => subject_code = value; }
        public string Subject_name { get => subject_name; set => subject_name = value; }
        public string Tag { get => tag; set => tag = value; }
        public string Group_code { get => group_code; set => group_code = value; }
        public int Student_count { get => student_count; set => student_count = value; }
        public int Duration { get => duration; set => duration = value; }
        public string Room { get => room; set => room = value; }

    }
}
