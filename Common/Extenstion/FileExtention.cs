using Common.Concrete.FileOperate;
using Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public static class FileExtention
    {
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
    }
}
