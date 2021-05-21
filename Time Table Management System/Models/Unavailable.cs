using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Models
{
    class Unavailable
    {
        private String room;
        private String day;
        private String start_time;
        private String end_time;
        private int id;

        public string Room { get => room; set => room = value; }
        public string Day { get => day; set => day = value; }
        public string Start_time { get => start_time; set => start_time = value; }
        public string End_time { get => end_time; set => end_time = value; }
        public int Id { get => id; set => id = value; }
    }
}
