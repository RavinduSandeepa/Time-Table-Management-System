using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Models
{
    class ConsecRoom
    {
        private int id;
        private int con_id;
        private String room;

        public int Id { get => id; set => id = value; }
        public int Con_id { get => con_id; set => con_id = value; }
        public String Room{ get => room; set => room = value; }
    }
}
