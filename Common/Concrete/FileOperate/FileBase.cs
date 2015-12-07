using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Common.Concrete.FileOperate
{
    public class FileBase<T>
       where T : class
    {
        public T objSource;
        public string fName;
        public string baseFolder = "Data";
        public FileBase()
        {
        }

        public T Read(string fileName)
        {
            T res;

            res = null;
            try
            {
                var temp = string.Empty;
                var localPath = Path.Combine(GetLocalPath(), baseFolder);
                var folder = GetFolder();
                var fPath = Path.Combine(Path.Combine(localPath, folder), fName + GetFileExtension());
                if (File.Exists(fPath))
                    temp = File.ReadAllText(fPath);
                res = DeseriaLize(temp);
            }
            catch (Exception e)
            {

            }
            return res;
        }

        internal virtual T DeseriaLize(string temp)
        {
            return temp.ToJsonObj<T>();
        }

        public bool Save(T obj, string fileName)
        {
            try
            {
                objSource = obj;
                fName = fileName;

                var content = Serialize();
                var localPath = Path.Combine(GetLocalPath(), baseFolder);
                var folder = GetFolder();
                var folderPath = Path.Combine(localPath, folder);
                var fPath = Path.Combine(folderPath, fName + GetFileExtension());
                if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
                if (Directory.Exists(fPath)) Directory.Delete(fPath);
                if (File.Exists(fPath)) File.Delete(fPath);
                File.WriteAllText(fPath, content, Encoding.UTF8);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        private string GetLocalPath()
        {
            var uri = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase));
            return uri.LocalPath;
        }

        internal virtual string GetFolder()
        {
            return string.Empty;
        }

        internal virtual string GetFileExtension()
        {
            return ".data";
        }

        internal virtual string Serialize()
        {
            return objSource.ToJson();
        }

        internal virtual Encoding GetEncodeing()
        {
            return Encoding.UTF8;
        }

        public virtual List<T> LoadFiles()
        {
            List<T> res;

            res = new List<T>();
            try
            {
                var temp = string.Empty;
                var localPath = Path.Combine(GetLocalPath(), baseFolder);
                var folder = GetFolder();
                var folderPath = Path.Combine(localPath, folder);
                var fPaths = Directory.GetFiles(folderPath, "*" + GetFileExtension());
                foreach (var fPath in fPaths)
                {
                    if (File.Exists(fPath))
                        temp = File.ReadAllText(fPath);
                    res.Add(DeseriaLize(temp));
                }
            }
            catch (Exception e)
            {
            }

            return res;
        }
    }
}
