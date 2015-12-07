using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class ChannelModel
    {
        public bool IsCDChannel;

        public string UserID;

        public string ChannelName { get; set; }

        public string Alias
        {
            get
            {
                return UserModel.Current.GetAlias(this.ChannelName, IsCDChannel);
            }
        }

        public string ChannelValue { get; set; }

    }
}
