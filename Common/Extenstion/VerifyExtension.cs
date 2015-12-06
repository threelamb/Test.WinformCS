using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public static class VerifyExtension
    {
        public static bool IsNullOrEmpty<T>(this List<T> p)
        {
            return p == null || p.Count == 0;
        }
    }
}
