using System;
using System.Collections.Generic;
using System.Text;
using Common.Extenstion;
using APILogin.Entity;

namespace APILogin
{
    public class LoginAPI : ILoginAPI
    {
        public LogInResponse Login(LogInRequest req)
        {
            LogInResponse res;

            res = null;
            if (req != null && !req.UserID.IsNullOrEmpity())
            {
                JsonRequest jsonReq = new JsonRequest(); 
                jsonReq.user = req.UserID;
                jsonReq.password = new Encryption.EncryptionContext().GetResult(req).RemoteVerifyStr;
                string postStr = jsonReq.ToJson();
                string resStr = new HttpPost.HttpPost().Post(postStr);
            }

            return res;
        }
    }
}
