using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Common.Concrete.FileOperate
{
    public class AccountFile<T> : FileBase<T>
        where T : class
    {
        string UserID;
        public AccountFile(string userID)
        {
            UserID = userID;
        }

        internal override string GetFolder()
        {
            return Path.Combine(UserID, "Account");
        }
    }
}
