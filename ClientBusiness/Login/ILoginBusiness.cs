using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientBusiness.Login
{
    public interface ILoginBusiness
    {
        bool VerifyPara(ref string message, string name, string passwrod);
        bool login(string user, string password);
    }
}
