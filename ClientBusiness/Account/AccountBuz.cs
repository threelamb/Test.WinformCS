using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Common;
using Common.Entity;

namespace ClientBusiness.Account
{
    public class AccountBuz : IAccountBuz
    {
        public List<string> GetDestinationByAccount(string account)
        {
            List<string> res = new List<string>();

            res.Add("ABC");
            res.Add("CDE");

            return res;
        }

        public void Save(Model.Account res)
        {
            res.SaveLocal<Model.Account>(FileType.Account, res.Alias);
        }

        public Model.Account Read(string fileName)
        {
            return fileName.ReadFile<Model.Account>(FileType.Account);
        }

        public List<Model.Account> LoadAccounts(string UserName)
        {
            return UserName.LoadFile<Model.Account>(FileType.Account);
        }
    }
}
