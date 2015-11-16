using APILogin.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace APILogin
{
    public interface ILoginAPI
    {
        LogInResponse Login(LogInRequest req);
    }
}
