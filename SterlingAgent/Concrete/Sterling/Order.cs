using APIAgent.Entity;
using APIAgent.Interface;
using Common.Concrete.Mapper;
using Common.Interface.Mapper;
using SterlingLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIAgent.Concrete.Sterling
{
    public class Order : IOrder
    {
        private STIOrder stiOrder;
        private STIQuote stiQuote = new SterlingLib.STIQuote();
        ITypeMapper typeMapper = new TypeMapper();

        public override int SubmitOrder()
        {
            int rs;

            stiOrder = typeMapper.Map<Order, STIOrderClass>(this);
            rs = stiOrder.SubmitOrder();
            
            return rs;
        }

        public override int SubmitOrder(ref OrderModel orderM)
        {
            int rs;

            stiOrder = typeMapper.Map<Order, STIOrderClass>(this);
            structSTIOrder sctSTIOrder = typeMapper.Map<OrderModel, structSTIOrder>(orderM);
            rs = stiOrder.SubmitOrderStruct(ref sctSTIOrder);
            orderM = typeMapper.Map<structSTIOrder, OrderModel>(sctSTIOrder);

            return rs;
        }
    }
}
