using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Clinic_Management_CSC_289_Capstone_Project
{
    public class Utilities
    {
        public static string hashPassword(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] password_bytes = Encoding.ASCII.GetBytes(password);
            byte[] encryted_bytes = sha1.ComputeHash(password_bytes);
            return Convert.ToBase64String(encryted_bytes);
        }
    }
}
