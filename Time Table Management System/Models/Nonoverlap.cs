using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Models
{
    class Nonoverlap
    {
        private int id;
        private int non1_id;
        private int non2_id;
        private int non3_id;
        private int non4_id;



        public int Id { get => id; set => id = value; }
        public int Non1_id { get => non1_id; set => non1_id = value; }
        public int Non2_id { get => non2_id; set => non2_id = value; }
        public int Non3_id { get => non3_id; set => non3_id = value; }
        public int Non4_id { get => non4_id; set => non4_id = value; }
    }
}
