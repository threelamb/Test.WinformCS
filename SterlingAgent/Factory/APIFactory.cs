using APIAgent.Concrete.Sterling;
using APIAgent.Interface;
using Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Text;

namespace APIAgent.Factory
{
    public class APIFactory
    {

        private static readonly string API = Config.GetAppSetting("APIAgent", "API");
        private static readonly string nameSpace;
        private static Assembly assembly;
        static APIFactory()
        {
            assembly = Assembly.GetExecutingAssembly();
            nameSpace = string.Format("APIAgent.Concrete.{0}.", API);
        }

        public static IOrder CreateOrder()
        {
            var rs = new Order();
            //var rs = (IOrder)assembly.CreateInstance(nameSpace + "Order");
            return rs;
        }

        public static IAccount CreateAccount()
        {
            var rs = new Account();
            //var rs = (IAccount)assembly.CreateInstance(nameSpace + "Account");
            return rs;
        }
    }
}
