﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using APIAgent.Factory;

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
            req.Password = "password1234";
            var res = new LoginAPI.LoginAPI().Login(req);
        }

        [TestMethod]
        public void Test_CreateOrder()
        {
            var order = APIFactory.CreateOrder();
            order.Account = "test";
            order.Symbol = "SIRI";
            order.Quantity = "1";
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
