using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace Controls.Component
{
    public partial class ChannelTag : UserControl
    {
        private ChannelModel _channel;
        private ChannelList channelList;
        public ChannelModel Channel
        {
            get
            {
                _channel.ChannelValue = this.cbb_Channel.SelectedItem.ToString();
                return _channel;
            }
            set
            {
                _channel = value;
                this.lbl_ChannelName.Text = _channel.ChannelName;
                this.lbl_Alias.Text = _channel.Alias;
                this.cbb_Channel.SelectedValue = _channel.ChannelValue;
            }
        }

        public ChannelTag(ChannelList channelList, ChannelModel c)
        {
            InitializeComponent();
            this.channelList = channelList;
            this.Channel = c;
        }

        public void SetChannelSource(List<string> source)
        {
            var value = this.cbb_Channel.SelectedValue;
            this.cbb_Channel.DataSource = source;
            this.cbb_Channel.SelectedItem = _channel.ChannelValue;
        }
    }
}
