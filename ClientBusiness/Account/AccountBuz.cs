using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Common;
using Common.Entity;
using APIAgent.Factory;
using Common.Concrete.FileOperate;

namespace ClientBusiness.Account
{
    public class AccountBuz : IAccountBuz
    {
        public List<string> GetDestinationByAccount(string account)
        {
            List<string> res = new List<string>();
            // #
            //if (account.IsNullOrEmpity())
            //{
            //    res.Add("ABC");
            //    res.Add("CDE");
            //}

            res = APIFactory.CreateOrder().GetDestinationList();

            return res;
        }

        public void Save(AccountModel para)
        {
            new AccountFile<AccountModel>(UserModel.Current.UserID).Save(para, para.Alias);
        }

        public Model.AccountModel Read(string fileName)
        {
            return new AccountFile<AccountModel>(UserModel.Current.UserID).Read(fileName);
        }

        public List<Model.AccountModel> LoadAccounts()
        {
            var res = new AccountFile<AccountModel>(UserModel.Current.UserID).LoadFiles();
            foreach (var item in res)
            {
                if (item.UserID.IsNullOrEmpity())
                {
                    item.UserID = UserModel.Current.UserID;
                }
            }
            return res;
        }
    }
}
