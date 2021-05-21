using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Models
{
    class Consecutive
    {
        private int id;
        private int con1_id;
        private int con2_id;


        public int Id { get => id; set => id = value; }
        public int Con1_id { get => con1_id; set => con1_id = value; }
        public int Con2_id { get => con2_id; set => con2_id = value; }

    }
}
