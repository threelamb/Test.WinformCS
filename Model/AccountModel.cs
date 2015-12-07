using APIAgent.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class AccountModel
    {
        public string UserID;

        //通用通道
        public List<ChannelModel> TYChannelList
        {
            get
            {
                if (_TYChannelList == null)
                {
                    _TYChannelList = new List<ChannelModel>();
                    for (int i = 0; i < 10; i++)
                    {
                        ChannelModel c = new ChannelModel();
                        c.ChannelName = "通用通道" + (i + 1).ToString();
                        c.ChannelValue = string.Empty;
                        c.IsCDChannel = false;
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

        private List<ChannelModel> _TYChannelList;

        /// <summary>
        /// 藏单通道
        /// </summary>
        public List<ChannelModel> CDChannelList
        {
            get
            {
                if (_CDChannelList == null)
                {
                    _CDChannelList = new List<ChannelModel>();
                    for (int i = 0; i < 10; i++)
                    {
                        ChannelModel c = new ChannelModel();
                        c.ChannelName = "藏单通道" + (i + 1).ToString();
                        c.ChannelValue = string.Empty;
                        c.IsCDChannel = true;
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

        private List<ChannelModel> _CDChannelList;

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
