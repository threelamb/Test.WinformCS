using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public static class StrExtension
    {
        public static string Connect(this string self, string str, string boundSymbol)
        {
            string res;

            if (!self.IsNullOrEmpity() && !str.IsNullOrEmpity())
            {
                res = self + boundSymbol + str;
            }
            else if (self.IsNullOrEmpity())
            {
                res = str;
            }
            else
            {
                res = self;
            }

            return res;
        }
    }
}
