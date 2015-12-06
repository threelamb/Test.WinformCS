using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using Common.Entity;
using System.IO;
using System.Reflection;
using Common;
using Common.Concrete.FileOperate;

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

        public static List<T> Clone<T>(this List<T> para)
        {
            List<T> res = new List<T>();

            foreach (var item in para)
            {
                res.Add(item);
            }

            return res;
        }

        public static bool SaveLocal<T>(this T para, FileType ft, string fileName)
            where T : class
        {
            bool res;

            res = false;
            try
            {
                switch (ft)
                {
                    case FileType.Account:
                        res = new AccountFile<T>().Save(para, fileName);
                        break;
                    case FileType.Strategy:
                        break;
                    case FileType.ActionLog:
                        break;
                    case FileType.ExceptionLog:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return res;
        }

        public static T ReadFile<T>(this string fileName, FileType ft)
            where T : class
        {
            T res;

            res = null;
            try
            {
                switch (ft)
                {
                    case FileType.Account:
                        res = new AccountFile<T>().Read(fileName);
                        break;
                    case FileType.Strategy:
                        break;
                    case FileType.ActionLog:
                        break;
                    case FileType.ExceptionLog:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return res;
        }

        public static List<T> LoadFile<T>(this string UserName, FileType ft)
            where T : class
        {
            List<T> res;

            res = new List<T>();
            try
            {
                switch (ft)
                {
                    case FileType.Account:
                        res = new AccountFile<T>().LoadFiles(UserName);
                        break;
                    case FileType.Strategy:
                        break;
                    case FileType.ActionLog:
                        break;
                    case FileType.ExceptionLog:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return res;

        }

        public static string GetString(this object para)
        {
            return para == null ? string.Empty : para.ToString();
        }
    }
}
