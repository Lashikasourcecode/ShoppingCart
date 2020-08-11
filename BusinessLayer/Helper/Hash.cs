using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BusinessLayer.Helper
{
    public class Hash
    {
        //add hash algorithems to 
        public string convertToHash(byte[] value)
        {
            using(SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(value);

                return Convert.ToBase64String(hash);
            }
                
        }
    }
}
