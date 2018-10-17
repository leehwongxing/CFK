using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Text;

namespace CFK_API.Compute
{
    public class Hash
    {
        public static string Saltier(string Content = "", string Salt = "")
        {
            var RawSalt = Encoding.UTF8.GetBytes(Salt);

            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                Content,
                RawSalt,
                KeyDerivationPrf.HMACSHA512,
                6666,
                512 / 8
                ));
        }

        public static bool Compare(string Password, string Salt, string Hashed)
        {
            if (string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Hashed))
            {
                return false;
            }
            return string.Compare(Saltier(Password, Salt), Hashed, true) == 0 ? true : false;
        }
    }
}