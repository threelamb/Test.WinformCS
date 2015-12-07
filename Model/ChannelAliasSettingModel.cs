using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ChannelAliasSettingModel
    {
        public string UserID;

        //通用通道
        public Dictionary<string, ChannelAliasModel> TYChannelList
        {
            get
            {
                if (_TYChannelList == null)
                {
                    _TYChannelList = new Dictionary<string, ChannelAliasModel>();
                    for (int i = 0; i < 10; i++)
                    {
                        ChannelAliasModel c = new ChannelAliasModel();
                        c.ChannelName = "通用通道" + (i + 1).ToString();
                        c.Alias = "通用通道" + (i + 1).ToString();
                        _TYChannelList.Add(c.ChannelName, c);
                    }
                }
                return _TYChannelList;
            }
            set
            {
                _TYChannelList = value;
            }
        }

        private Dictionary<string, ChannelAliasModel> _TYChannelList;

        /// <summary>
        /// 藏单通道
        /// </summary>
        public Dictionary<string, ChannelAliasModel> CDChannelList
        {
            get
            {
                if (_CDChannelList == null)
                {
                    _CDChannelList = new Dictionary<string, ChannelAliasModel>();
                    for (int i = 0; i < 10; i++)
                    {
                        ChannelAliasModel c = new ChannelAliasModel();
                        c.ChannelName = "藏单通道" + (i + 1).ToString();
                        c.Alias = "藏单通道" + (i + 1).ToString();
                        _CDChannelList.Add(c.ChannelName, c);
                    }
                }
                return _CDChannelList;
            }
            set
            {
                _CDChannelList = value;
            }
        }

        private Dictionary<string, ChannelAliasModel> _CDChannelList;

        public string GetTYAlias(string p)
        {
            return TYChannelList[p].Alias;
        }

        public string GetCDAlias(string p)
        {
            string res = string.Empty;
            ChannelAliasModel m;
            if(CDChannelList.TryGetValue(p, out m))
                res = m.Alias;
            return res;
        }
    }
}
