using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APILogin.Entity
{
    public class LogInRequest
    {
        public string UserID { get; set; }
        public string Password { get; set; }
    }
}
