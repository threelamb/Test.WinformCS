﻿using LoginAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
///
using Common;
using Model;
using ClientBusiness.User;

namespace ClientBusiness.Login
{
    public class LoginBuz : ILoginBuz
    {
        public bool login(string user, string password)
        {
            bool res = false;

            var req = new LoginAPI.Entity.LogInRequest() { UserID = user, Password = password };
            ILoginAPI ILoginAPI = new LoginAPI.LoginAPI();
            //var resp = ILoginAPI.Login(req);
            //res = resp.Success;

            //#
            res = true;

            new UserBuz().login(user);

            return res;
        }

        public bool VerifyPara(ref string message, string name, string passwrod)
        {
            bool res = false;

            if (name.IsNullOrEmpity())
            {
                message = Resource.Resource.mbox_needName;
            }
            if (passwrod.IsNullOrEmpity())
            {
                message = message.IsNullOrEmpity()
                    ? Resource.Resource.mbox_needPassword
                    : message.Connect(Resource.Resource.mbox_needPassword, "\n");
            }

            if (message.IsNullOrEmpity())
            {
                res = true;
            }

            return res;
        }
    }
}
