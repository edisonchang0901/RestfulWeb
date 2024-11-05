using System.Security.Cryptography;
using System.Text;

namespace RestfulWeb.Domain.Common
{
    public static class Util
    {
        public static string HashSHA512(string passsword, byte[] salt) 
        {
            const int KEY_SIZE = 32;
            const int ITERATIONS = 100000;
            HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;

            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(Encoding.UTF8.GetBytes(passsword),
                                                    salt,
                                                    ITERATIONS,
                                                    hashAlgorithm,
                                                    KEY_SIZE);
            return Convert.ToHexString(hash);
        }

        public static byte[] GenerateSalt() => RandomNumberGenerator.GetBytes(128 / 8);
    }
}
