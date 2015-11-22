using APIAgent.Entity;
using Common.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIAgent.Interface
{
    public abstract class IOrder
    {
        public string Symbol { get; set; }
        public string Account { get; set; }
        public string Side { get; set; }
        public string Quantity { get; set; }
        public string Destination { get; set; }
        public PriceTypes PriceType { get; set; }
        public string Tif { get; set; }
        public string ClOrderID { get; set; }
        public abstract int SubmitOrder();
        public abstract int SubmitOrder(ref OrderModel structOrder);
        public abstract int CancelOrder();
        public abstract string MakeClOrderID(string account);
        public abstract Array GetDestinationList();
    }
}
