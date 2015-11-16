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
            var a = Resource.Resource.Culture;
            var name = Resource.Resource.lbl_name;
            var b = Thread.CurrentThread.CurrentCulture;
            var c = Thread.CurrentThread.CurrentUICulture;
            Resource.Resource.Culture = new System.Globalization.CultureInfo("en-US");
            var name1 = Resource.Resource.lbl_name;
            var d = Resource.Resource.Culture;
            
            new Thread(new ThreadStart(target)).Start();
        }

        void target()
        {
            var a = Resource.Resource.Culture;
            var name = Resource.Resource.lbl_name;
            var b = Thread.CurrentThread.CurrentCulture;
            var c = Thread.CurrentThread.CurrentUICulture;
            Resource.Resource.Culture = new System.Globalization.CultureInfo("zh-CN");
            var name1 = Resource.Resource.lbl_name;
            var d = Resource.Resource.Culture;
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
        }
    }
}
