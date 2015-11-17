using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace Common
{
    public static class TypeExtension
    {
        public static bool IsNullOrEmpity(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static string ToJson(this object obj)
        {
            return new JavaScriptSerializer().Serialize(obj);
        }

        public static T ToJsonObj<T>(this string json)
        {
            return new JavaScriptSerializer().Deserialize<T>(json);
        }
    }
}
