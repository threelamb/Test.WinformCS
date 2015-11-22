﻿using APIAgent.Entity;
using APIAgent.Interface;
using Common.Concrete.Mapper;
using Common.Interface.Mapper;
using SterlingLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace APIAgent.Concrete.Sterling
{
    public class Order : IOrder
    {
        private STIOrder stiOrder;
        private STIQuote stiQuote = new STIQuote();
        private STIApp stiapp = new STIApp();
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
            var sctSTIOrder = typeMapper.Map<OrderModel, structSTIOrder>(orderM);
            rs = stiOrder.SubmitOrderStruct(ref sctSTIOrder);
            orderM = typeMapper.Map<structSTIOrder, OrderModel>(sctSTIOrder);

            return rs;
        }

        public override int CancelOrder()
        {
            return 1;
        }

        public override string MakeClOrderID(string account)
        {
            string res;

            SYSTEMTIME st = new SYSTEMTIME();
            LibWrap.GetSystemTime(st);
            res = account + st.wYear + st.wMonth + st.wDay + st.wHour + st.wMinute + st.wSecond + st.wMilliseconds;

            return res;
        }

        public override Array GetDestinationList()
        {
            Array res = System.Array.CreateInstance(typeof(string), 0);
            try
            {
                stiapp.GetDestinationList(ref res);
            }
            catch (Exception ex)
            {
                throw;
            }

            return res;
        }
    }

    public class SYSTEMTIME
    {
        public ushort wYear;
        public ushort wMonth;
        public ushort wDayOfWeek;
        public ushort wDay;
        public ushort wHour;
        public ushort wMinute;
        public ushort wSecond;
        public ushort wMilliseconds;
    }

    public class LibWrap
    {
        [DllImport("Kernel32.dll")]
        public static extern void GetSystemTime([In, Out] SYSTEMTIME st);
    }
}
