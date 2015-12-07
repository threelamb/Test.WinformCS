using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Common.Concrete.FileOperate
{
    public class LogFile : IFile
    {
        public static bool Appand(string para)
        {
            try
            {
                var content = "\r\n" + DateTime.Now.ToString() + "\r\n" + para;
                string fName = GetFileName();

                var localPath = Path.Combine(GetLocalPath(), baseFolder);
                var folder = GetFolder();
                var folderPath = Path.Combine(localPath, folder);
                var fPath = Path.Combine(folderPath, fName + GetFileExtension());
                if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
                if (Directory.Exists(fPath)) Directory.Delete(fPath);
                File.AppendAllText(fPath, content, Encoding.UTF8);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        private static string GetFileExtension()
        {
            return ".Data";
        }

        private static string GetFileName()
        {
            return (DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day).ToString();
        }

        private static string GetFolder()
        {
            return "Log";
        }
    }
}
