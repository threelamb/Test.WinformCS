using APIAgent.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Text;

namespace APIAgent.Factory
{
    public class APIFactory
    {
        private static readonly string APINameSpace = ConfigurationManager.AppSettings["APINameSpace"];
        private static readonly string APIAssemblyName = ConfigurationManager.AppSettings["APIAssemblyName"];
        private static readonly Assembly Assembly;

        static APIFactory()
        {
            Assembly = Assembly.Load(APIAssemblyName);
        }

        public static IOrder CreateOrder()
        {
            var result = (IOrder)Assembly.CreateInstance(APINameSpace + "Order");

            return result;
        }
    }
}
