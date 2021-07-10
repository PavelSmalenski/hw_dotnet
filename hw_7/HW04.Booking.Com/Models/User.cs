using System;
using System.Collections.Generic;
using System.Text;

namespace HW04.Booking.Com.Models
{
    class User
    {
        Guid _id = Guid.NewGuid();
        string _login;
        string _password;
        public string Login
        {
            get
            {
                return _login;
            }
        }

        public User(string login, string password)
        {
            _login = login;
            _password = password;
        }

        public bool VerifyPassword(string password)
        {
            if (_password == password)
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
