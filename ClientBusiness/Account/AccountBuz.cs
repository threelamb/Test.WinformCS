using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Common;
using Common.Entity;
using APIAgent.Factory;

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

        public void Save(Model.AccountModel res)
        {
            res.SaveLocal<Model.AccountModel>(FileType.Account, res.Alias);
        }

        public Model.AccountModel Read(string fileName)
        {
            return fileName.ReadFile<Model.AccountModel>(FileType.Account);
        }

        public List<Model.AccountModel> LoadAccounts(string UserName)
        {
            return UserName.LoadFile<Model.AccountModel>(FileType.Account);
        }
    }
}
