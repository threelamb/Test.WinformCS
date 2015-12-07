using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class CommandModel
    {
        public CommandType type;
        public CommandContent content;
    }

    public enum CommandType
    {
        /// <summary>
        /// 延迟等待
        /// </summary>
        Waite = 0,
        /// <summary>
        /// 普通订单
        /// </summary>
        NormOrder = 1,
        /// <summary>
        /// 普通藏单
        /// </summary>
        NormHiden = 2,
        /// <summary>
        /// 基准订单
        /// </summary>
        StandOrder = 3,
        /// <summary>
        /// 基准藏单
        /// </summary>
        StandHiden = 4,
        /// <summary>
        /// 撤销全部订单
        /// </summary>
        CancelAll = 5
    }

    public enum CancelType
    {
        All = 0
    }

    public class CommandContent
    {
    }

    public class Waite : CommandContent
    {
        public double time;
    }

    public class Order : CommandContent
    {
        public string Name;
        public string Account;
        public string Direction;
        public int OrderCount;
        List<string> Channels;
        public string PiceFromScreen;
        public string CountFromScreen;
        public string Symbol;
    }

    public class NormOrder : Order
    {
        public string Count;
        public double Price;
    }

    public class NormHiden : Order
    {
        public double Count;
        public double Price;
        public double DisplayCount;
    }

    public class StandOrder : Order
    {
        public double CountRate;
        public double PriceAdd;
    }

    public class StandHiden : Order
    {
        public double CountRate;
        public double PriceAdd;
        public double DisplayCount;
    }

    public class CancelAll : CommandContent
    {
        public CancelType CancelType;
    }
}
