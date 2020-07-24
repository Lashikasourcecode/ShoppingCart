using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BusinessLayer.Shared
{
    public class shared
    {
        public static string Hash(byte[] passValue)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hashVal = sha1.ComputeHash(passValue);
                return Convert.ToBase64String(hashVal);

            }
        }
    }
}
