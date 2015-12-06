using APIAgent.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Account
    {
        //通用通道
        public List<Channel> TYChannelList
        {
            get
            {
                if (_TYChannelList == null)
                {
                    _TYChannelList = new List<Channel>();
                    for (int i = 0; i < 10; i++)
                    {
                        Channel c = new Channel();
                        c.ChannelName = "通用通道" + (i + 1).ToString();
                        c.ChannelValue = string.Empty;
                        c.Alias = "通用通道" + (i + 1).ToString();
                        _TYChannelList.Add(c);
                    }
                }
                return _TYChannelList;
            }
            set
            {
                _TYChannelList = value;
            }
        }

        private List<Channel> _TYChannelList;

        /// <summary>
        /// 藏单通道
        /// </summary>
        public List<Channel> CDChannelList
        {
            get
            {
                if (_CDChannelList == null)
                {
                    _CDChannelList = new List<Channel>();
                    for (int i = 0; i < 10; i++)
                    {
                        Channel c = new Channel();
                        c.ChannelName = "藏单通道" + (i + 1).ToString();
                        c.ChannelValue = string.Empty;
                        c.Alias = "藏单通道" + (i + 1).ToString();
                        _CDChannelList.Add(c);
                    }
                }
                return _CDChannelList;
            }
            set
            {
                _CDChannelList = value;
            }
        }

        private List<Channel> _CDChannelList;

        public string AccountName { get; set; }

        public string Alias { get; set; }

        public string IP { get; set; }

        private List<string> _ChannelSource { get; set; }

        public List<string> ChannelSource
        {
            get
            {
                if (_ChannelSource == null
                    || _ChannelSource.Count == 0)
                {
                    try
                    {
                        //#
                        _ChannelSource = APIFactory.CreateOrder().GetDestinationList();
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                }

                return _ChannelSource;
            }
            set
            {
                _ChannelSource = value;
            }
        }

        public bool IsEnable { get; set; }

        public bool IsConnected { get; set; }

        public string Channel { get; set; }
    }
}
