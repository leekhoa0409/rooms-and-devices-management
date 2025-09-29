using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class Session
    {
        public static string currentUser { get; set; }
        public static string currentRole { get; set; }

        public static void Clear()
        {
            currentUser = null;
            currentRole = null;
        }
    }
}
