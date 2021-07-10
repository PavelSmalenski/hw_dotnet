using HW04.Booking.Com.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW04.Booking.Com.Controls
{
    static class AccessControl
    {
        static List<User> _registeredUsers = new List<User>();
        static List<Guid> _activeSessions = new List<Guid>();

        static public void RegisterUser(string login, string password)
        {
            _registeredUsers.Add(new User(login, password));
            Console.WriteLine("User registered!");
        }

        static public Guid? Logon(string login, string password)
        {
            User match = _registeredUsers.Find(user => user.Login == login);
            if (match != null)
            {
                if (match.VerifyPassword(password))
                {
                    Guid session = Guid.NewGuid(); // I know that such session ID's are always generated based on UID and get decoded each time "check" is performed, but for our purposes - that's enough
                    _activeSessions.Add(session);
                    return session;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        static public void Logoff(Guid session)
        {
            int i = _activeSessions.IndexOf(session);
            if (i >= 0)
            {
                _activeSessions.RemoveAt(i);
            }
        }

        static public bool VerifySession(Guid session)
        {
            if (_activeSessions.IndexOf(session) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
