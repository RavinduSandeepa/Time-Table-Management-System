using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Models
{
    class ParalleDTO
    {
        private int id;
        private int par1_id;
        private int par2_id;
        private int par3_id;


        public int Id { get => id; set => id = value; }
        public int Par1_id { get => par1_id; set => par1_id = value; }
        public int Par2_id { get => par2_id; set => par2_id = value; }
        public int Par3_id { get => par3_id; set => par3_id = value; }
    }
}
