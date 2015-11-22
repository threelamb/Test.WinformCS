using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using Common.Entity;

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

        public static List<KeyValue<string, string>> GetKeyValue<T>(this T para)
            where T : class
        { 
            List<KeyValue<string, string>> res;
            var type = typeof(T);

            res = new List<KeyValue<string, string>>();
            var pros = type.GetFields();
            foreach (var proInfo in pros)
            {
                res.Add(new KeyValue<string, string>(proInfo.Name, proInfo.GetValue(para).ToString()));
            }

            return res;
        }

        public static List<KeyValue<string, string>> GetEnumKeyValue<T>(this T para)
        {
            List<KeyValue<string, string>> res;
            var type = typeof(T);

            res = new List<KeyValue<string, string>>();
            foreach (int value in Enum.GetValues(type))
            {
                string name = Enum.GetName(type, value);
                res.Add(new KeyValue<string, string>(name, value.ToString()));
            }

            return res;
        }
    }
}
