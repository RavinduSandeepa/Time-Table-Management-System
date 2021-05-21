using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    interface ISessionService
    {
        Boolean addSession(SessionDTO session);
        List<SessionDTO> getAllSessions();
        SessionDTO GetSession(int id);
        Boolean deleteSession(int id);
        Boolean updateSession(int id, SessionDTO session);
        List<SessionDTO> searchSession(String key, String type);
    }
}
