using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APILogin.Encryption
{
    class EncryptionResult
    {
        /// <summary>
        /// 用于远程认证
        /// </summary>
        public string RemoteVerifyStr;
        /// <summary>
        /// 用于本地认证
        /// </summary>
        public string LocalVerifyStr;
    }
}
