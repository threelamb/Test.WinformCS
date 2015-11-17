using LoginAPI.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginAPI.Encryption
{
    internal interface IEncryption
    {
        EncryptionResult Encrypt(LogInRequest req);
    }
}
