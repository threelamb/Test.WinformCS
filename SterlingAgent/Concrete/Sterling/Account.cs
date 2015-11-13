using APIAgent.Interface;
using SterlingLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APIAgent.Concrete.Sterling
{
    class Account : IAccount
    {
        public string GetAccount()
        {
            string rs = string.Empty;

            STIAcctMaint acc = new STIAcctMaint();
            Array pAcc = Array.CreateInstance(typeof(string), 1);
            acc.GetAccountList(ref pAcc);
            if (pAcc != null && pAcc.Length > 0)
            {
                rs = pAcc.GetValue(0).ToString();
            }

            return rs;
        }
    }
}
