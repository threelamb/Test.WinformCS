using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using APIAgent.Factory;
using APIAgent.Concrete;

namespace UnitTestForAPIAgent
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_CreateOrder()
        {
            var order = APIFactory.CreateOrder();
        }
    }
}
