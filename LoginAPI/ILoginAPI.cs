using LoginAPI.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginAPI
{
    public interface ILoginAPI
    {
        LogInResponse Login(LogInRequest req);
    }
}
