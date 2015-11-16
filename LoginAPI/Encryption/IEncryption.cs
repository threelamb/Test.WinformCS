using APILogin.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace APILogin.Encryption
{
    internal interface IEncryption
    {
        EncryptionResult Encrypt(LogInRequest req);
    }
}
