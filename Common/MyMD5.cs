using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Common
{
    public class MyMD5
    {
        public static string Md5(string str)
        {
            string res;

            StringBuilder sb = new StringBuilder();
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            foreach (var item in result)
            {
                sb.Append(item.ToString("x2"));
            }
            res = sb.ToString();

            return res;
        }
    }
}
