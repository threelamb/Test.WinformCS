using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace UnitTestForResource
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_ResourceAndThreadCulture()
        {
            //Only CurrentUICulture reflect the Resource.Culture when Resource.Culture == null.
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US"); 
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            var name = Resource.Resource.lbl_name;
            new Thread(new ThreadStart(target)).Start();
        }

        void target()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            var name = Resource.Resource.lbl_name;
            new Thread(new ThreadStart(target)).Start();
        }
    }
}
