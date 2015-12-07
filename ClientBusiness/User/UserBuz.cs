using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace ClientBusiness.User
{
    public class UserBuz
    {
        private string user;

        public UserBuz(string user)
        {
            // TODO: Complete member initialization
            this.user = user;
        }

        internal void login()
        {
            UserModel.Current = GetUser(this.user);
        }

        public UserModel GetUser(string user)
        {
            var res = new UserModel();

            var Temp = user.LoadFile<UserModel>(Common.Entity.FileType.User);
            if (Temp != null)
            {
                foreach (var item in Temp)
                {
                    if (item.UserID == user)
                    {
                        res = item;
                        break;
                    }
                }
            }

            return res;
        }
    }
}
