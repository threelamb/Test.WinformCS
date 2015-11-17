using System;
using System.Collections.Generic;
using System.Text;
using Common;
using LoginAPI.Entity;

namespace LoginAPI
{
    public class LoginAPI : ILoginAPI
    {
        public LogInResponse Login(LogInRequest req)
        {
            LogInResponse res;

            res = new LogInResponse();
            if (req != null && !req.UserID.IsNullOrEmpity())
            {
                JsonRequest jsonReq = new JsonRequest();
                jsonReq.user = req.UserID;
                jsonReq.password = new Encryption.EncryptionContext().GetResult(req).RemoteVerifyStr;
                string postStr = jsonReq.ToJson();
                string resStr = new HttpPost.HttpPost().Post(postStr);
                var jsonResp = resStr.ToJsonObj<JsonResponse>();
                if (jsonResp != null && jsonResp.data != null)
                {
                    res.Success = true;
                    res.Data = jsonResp.data;
                }
            }

            return res;
        }
    }
}
