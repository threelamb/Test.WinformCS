using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class UserModel
    {
        static UserModel()
        {
            _ChannelSetting = new ChannelAliasSettingModel();
        }

        public string UserID;
        static ChannelAliasSettingModel _ChannelSetting;
        public ChannelAliasSettingModel ChannelSetting
        {
            get
            {
                return _ChannelSetting;
            }
            set
            {
                _ChannelSetting = value;
            }
        }
        public List<AccountModel> AccountList;
        public static UserModel Current;

        internal string GetAlias(string p, bool IsCDChannel)
        {
            if (IsCDChannel)
                return ChannelSetting.GetCDAlias(p);
            return ChannelSetting.GetTYAlias(p);
        }
    }
}
