using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Common.Concrete.FileOperate;

namespace ClientBusiness.User
{
    public class UserBuz
    {
        internal void login(string user)
        {
            UserModel.Current = GetUser(user);
        }

        public UserModel GetUser(string user)
        {
            var res = new UserModel();

            var Temp = new UserFile<UserModel>().Read(user);
            if (Temp != null)
            {
                res = Temp;
            }
            res.UserID = user;

            return res;
        }

        public void Save()
        {
            //new UserFile
        }
    }
}
