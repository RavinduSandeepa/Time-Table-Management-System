using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Models
{
    class WorkingDaysHours
    {
        private int id;
        private int noOfWorkingDays;
        private int monday;
        private int tuesday;
        private int wednesday;
        private int thursday;
        private int friday;
        private int saturday;
        private int sunday;
        private int noOfHours;
        private int noOfMinutes;

        public int NoOfWorkingDays { get => noOfWorkingDays; set => noOfWorkingDays = value; }
        public int Monday { get => monday; set => monday = value; }
        public int Tuesday { get => tuesday; set => tuesday = value; }
        public int Wednesday { get => wednesday; set => wednesday = value; }
        public int Thursday { get => thursday; set => thursday = value; }
        public int Friday { get => friday; set => friday = value; }
        public int Saturday { get => saturday; set => saturday = value; }
        public int Sunday { get => sunday; set => sunday = value; }
        public int NoOfHours { get => noOfHours; set => noOfHours = value; }
        public int NoOfMinutes { get => noOfMinutes; set => noOfMinutes = value; }
        public int Id { get => id; set => id = value; }
    }
}
