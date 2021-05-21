using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Models
{
    class TimeSlot
    {
        private int id;
        private int stHours;
        private int stMinutes;
        private int etHours;
        private int etMinutes;
        private String duration;

        public int StHours { get => stHours; set => stHours = value; }
        public int StMinutes { get => stMinutes; set => stMinutes = value; }
        public int EtHours { get => etHours; set => etHours = value; }
        public int EtMinutes { get => etMinutes; set => etMinutes = value; }
        public int Id { get => id; set => id = value; }
        public String Duration { get => duration; set => duration = value; }
    }
}
