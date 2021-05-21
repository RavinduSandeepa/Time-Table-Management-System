using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Models
{
    class Notavailable
    {
        private int id;
        private String lec_name;
        private String group_code;
        private String subgroup_code;
        private int session_id;
        private String duration;

        public int Id { get => id; set => id = value; }
        public string Lec_name { get => lec_name; set => lec_name = value; }
        public string Group_code { get => group_code; set => group_code = value; }
        public string Subgroup_code { get => subgroup_code; set => subgroup_code = value; }
        public int Session_Id { get => session_id; set => session_id = value; }
        public string Duration { get => duration; set => duration = value; }
    }
}
