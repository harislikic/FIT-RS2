using System;
using System.Security.Cryptography;

namespace AutoTrader.Services.PasswordHash
{
    public class PasswordHasher
    {
        private const int SaltSize = 16;
        private const int Iterations = 10000;
        private const int HashSize = 20;

        public static (string hash, string salt) HashPassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            byte[] hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            string saltString = Convert.ToBase64String(salt);
            string hashString = Convert.ToBase64String(hashBytes);

            return (hashString, saltString);
        }
    }


}

