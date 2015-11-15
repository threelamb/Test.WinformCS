using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Extenstion
{
    public static class TypeExtension
    {
        public static bool IsNullOrEmpity(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
}
