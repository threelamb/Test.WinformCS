using Common;
using APILogin.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace APILogin.Encryption
{
    internal class MD5Encryption : IEncryption
    {
        string SALT1 = "X4VM4QTLN6T3dVZFjElVSpcbe27AJAaaKhJw8Lpl3Xrsz4gMN4Ceow5SGd5QWVBpdqZZn/NNfg6CH9oJMg8E+Q==";
        string SALT2 = "DgAbQIKKN36ZwDm7xi3AT2KVET9Hail9wUUF2ReRIyZvNeZ1mJEnwqlrvmRzmg66hUPoArh5NPTJ5xnZktCPcQ==";
        string SALT3 = "jZf1yR0q+FSyEzcooJi0MvDxvXqZTy4V+lzf3zuweB6U7AXx1f190lmBpBjUv3qtYHAH2YIVOxryef8+cUDtHw==";

        private string Md5(string p)
        {
            return MyMD5.Md5(p);
        }

        public EncryptionResult Encrypt(LogInRequest req)
        {
            EncryptionResult res;

            var UserID = req.UserID;
            var Password = req.Password;
            res = new EncryptionResult();
            var A = Md5(Password + SALT1);
            res.RemoteVerifyStr = Md5(Md5(A + UserID) + SALT2);
            res.LocalVerifyStr = Md5(res.RemoteVerifyStr + SALT3);

            return res;
        }
    }
}
