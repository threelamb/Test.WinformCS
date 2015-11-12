using APIAgent.Interface;
using Common.Interface.Mapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIAgent.Concrete.Sterling
{
    class Order : IOrder
    {
        private SterlingLib.STIOrder stiOrder;
        private SterlingLib.STIQuote stiQuote = new SterlingLib.STIQuote(); 
        public override int SubmitOrder()
        {
            return 1;
        }

        public override int SubmitOrder(ref Entity.StructOrder structOrder)
        {
            throw new NotImplementedException();
        }
    }
}
