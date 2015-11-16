using Common;
using APILogin.Entity;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace APILogin.Encryption
{
    internal class EncryptionContext
    {
        private readonly string EncryptionStrategy = Config.GetAppSetting("LoginConfig", "EncryptionStrategy");
        IEncryption encryption;

        public EncryptionContext()
        {
            encryption = (IEncryption)Assembly.GetExecutingAssembly().CreateInstance(string.Format("LoginAPI.Encryption.{0}Encryption",EncryptionStrategy));
        }
        public EncryptionResult GetResult(LogInRequest req)
        {
            return encryption.Encrypt(req);
        }
    }
}
