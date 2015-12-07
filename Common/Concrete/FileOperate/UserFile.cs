using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Concrete.FileOperate
{
    class UserFile<T> : FileBase<T>
        where T : class
    {
        internal override string GetFolder()
        {
            return "User";
        }
    }
}
