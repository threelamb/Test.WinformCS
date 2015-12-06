using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Concrete.FileOperate
{
    public class AccountFile<T> : FileBase<T>
        where T : class
    {
        public AccountFile()
        {

        }

        internal override string GetFolder()
        {
            return "Account";
        }
    }
}
