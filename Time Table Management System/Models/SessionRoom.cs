using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Models
{
    class SessionRoom
    {
        private int id;
        private int session_id;
        private String room;

        public int Id { get => id; set => id = value; }
        public int Session_id { get => session_id; set => session_id = value; }
        public String Room { get => room; set => room = value; }
    }
}
