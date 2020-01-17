using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.utils
{
    class HexUtil
    {
        //private static readonly char[] HEX = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
        //	'a', 'b', 'c', 'd', 'e', 'f' };

        public static string Encode(byte[] bytes)
        {
            string hexString = string.Empty;
            if (bytes != null)
            {
                StringBuilder strB = new StringBuilder();
                foreach (byte b in bytes)
                {
                    strB.AppendFormat("{0:x2}", b);
                }
                hexString = strB.ToString();
            }
            return hexString;

            //int nBytes = bytes.Length;
            //char[] result = new char[2 * nBytes];

            //int j = 0;
            //for (int i = 0; i < nBytes; i++)
            //{
            //	// Char for top 4 bits
            //	result[j++] = HEX[(0xF0 & bytes[i]) >>> 4];
            //	// Bottom 4
            //	result[j++] = HEX[(0x0F & bytes[i])];
            //}

            //return result;
        }
    }
}
