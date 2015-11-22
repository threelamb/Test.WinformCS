using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using APIAgent.Factory;
using APIAgent.Entity;
using SterlingLib;
using System.Collections;

namespace UnitTestForAPIAgent
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Login()
        {
            var req = new LoginAPI.Entity.LogInRequest();
            req.UserID = "catsky";
            req.Password = "password";
            var res = new LoginAPI.LoginAPI().Login(req);
        }

        [TestMethod]
        public void Test_CreateOrder()
        {
            var order = APIFactory.CreateOrder();
            order.Account = "IF030WZPA";
            order.Symbol = "SIRI";
            order.Quantity = "1";
            order.Side = Side.Sell;
            order.PriceType = APIAgent.Entity.PriceTypes.ptSTIMkt;
            order.Tif = Tifs.DAY;
            order.Destination = Destination.EDGA;
            order.ClOrderID = order.MakeClOrderID(order.Account);

            var rs = order.SubmitOrder();
        }

        [TestMethod]
        public void Test_CreateAccount()
        {
            var account = APIFactory.CreateAccount();
            var rs = account.GetAccount();
        }
    }
}
