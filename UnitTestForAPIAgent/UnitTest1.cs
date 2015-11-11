using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using APIAgent.Factory;

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
