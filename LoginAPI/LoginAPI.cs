using System;
using System.Collections.Generic;
using System.Text;
using Common.Extenstion;
using LoginAPI.Entity;

namespace LoginAPI
{
    public class LoginAPI : ILoginAPI
    {
        public LogInResponse Login(LogInRequest req)
        {
            LogInResponse res;

            res = null;
            if (req != null && !req.UserID.IsNullOrEmpity())
            {
                string postStr = new Encryption.EncryptionContext().GetResult(req).B;
                string resStr = new HttpPost.HttpPost().Post(postStr);
            }

            return res;
        }
    }
}
