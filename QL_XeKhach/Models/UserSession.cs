using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XeKhach.Models
{
    public static class UserSession
    {
        public static User LoggedInUser { get; set; }

        public static bool IsLoggedIn()
        {
            return LoggedInUser != null;
        }
    }
}
