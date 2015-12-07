using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Common.Concrete.FileOperate
{
    public class IFile
    {
        public static string baseFolder = "Data";

        internal static string GetLocalPath()
        {
            var uri = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase));
            return uri.LocalPath;
        }
    }
}
