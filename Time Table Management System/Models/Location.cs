using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.Models
{
    class Location
    {
        private String buildingName;
        private String roomName;
        private String roomType;
        private String capacity;
        private int id;

        public string BuildingName { get => buildingName; set => buildingName = value; }
        public string RoomName{ get => roomName; set => roomName = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        public string Capacity { get => capacity; set => capacity = value; }
        public int Id { get => id; set => id = value; }
    }
}

