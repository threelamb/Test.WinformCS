using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestForAPIAgent
{
    [TestClass]
    public class TestSterlingAPI
    {
        [TestMethod]
        public void Test_OnSTILinkSymChange()
        {
            SterlingLib.STIEvents stiEvent = new SterlingLib.STIEvents();
            SterlingLib.STIApp stiapp = new SterlingLib.STIApp();

            stiEvent.OnSTILinkSymChange += stiEvent_OnSTILinkSymChange;
            stiapp.SwitchLinkGroupSymbol(1, "IBM 120727C215000", "O");
        }

        void stiEvent_OnSTILinkSymChange(ref SterlingLib.structSTILink structLink)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Test_OnSTIOrderReject()
        {
            SterlingLib.STIEvents stiEvent = new SterlingLib.STIEvents();
            stiEvent.OnSTIOrderReject += stiEvent_OnSTIOrderReject;
        }

        void stiEvent_OnSTIOrderReject(ref SterlingLib.structSTIOrderReject structLink)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Test_GetDestinationList()
        {
            SterlingLib.STIApp stiapp = new SterlingLib.STIApp();

            Array res = System.Array.CreateInstance(typeof(string), 0);
            try
            {
                stiapp.GetDestinationList(ref res);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
