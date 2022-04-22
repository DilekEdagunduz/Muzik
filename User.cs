using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Muzik
{
    public class User
    {
        public User()
        {

        }
        public User(string name, string surname)
        {

        }
        public string Email { get; set; }
        public string Adress { get; set; }
        string password = "";
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = CreateMD5(value);
            }
        }
        public static string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes);
            }
        }
    }
}
