using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.utils
{
    class HmacUtil
    {
        
        public static string Encode(string message, string key)
        {
            string signRet = string.Empty;
            var encoding = new System.Text.UTF8Encoding();
            byte[] keyByte = encoding.GetBytes(key);
            byte[] messageBytes = encoding.GetBytes(message);
            using (var hmacSHA256 = new HMACSHA256(keyByte))
            {
                byte[] hashMessage = hmacSHA256.ComputeHash(messageBytes);
                signRet = HexUtil.Encode(hashMessage);
            }
            return signRet;
        }

        public static string Sign(string message, string key) {
            string signRet = string.Empty;
            var encoding = new System.Text.UTF8Encoding();
            byte[] keyByte = encoding.GetBytes(key);
            byte[] messageBytes = encoding.GetBytes(message);
            using (var hmacSHA256 = new HMACSHA256(keyByte)) {
                byte[] hashMessage = hmacSHA256.ComputeHash(messageBytes);
                signRet = Convert.ToBase64String(hashMessage);
            }
            return signRet;
        }
    }
}
