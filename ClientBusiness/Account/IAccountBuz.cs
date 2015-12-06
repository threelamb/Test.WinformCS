using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientBusiness.Account
{
    public interface IAccountBuz
    {
        List<string> GetDestinationByAccount(string account);
    }
}
