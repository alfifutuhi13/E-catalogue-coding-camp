using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Handlers
{
    public class Hash
    {
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool ValidatePassword(string password, string passwordHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }
    }
}
