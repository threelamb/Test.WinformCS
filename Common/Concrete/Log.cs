using Common.Concrete.FileOperate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Concrete
{
    public class Log
    {
        public static void WriteLine(string p)
        {
            LogFile.Appand(p);
        }
    }
}
