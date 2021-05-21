using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    interface ISessionRoomService
    {
        Boolean addSessionRoom(SessionRoom room);
        List<SessionRoom> getAllSessionRooms();
        SessionRoom GetSessionRoom(int id);
        Boolean deleteSessionRoom(int id);
        Boolean updateSession(int id, SessionRoom room);
    }
}
