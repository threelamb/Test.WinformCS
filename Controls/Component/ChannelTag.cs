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
        private Channel _channel;
        private ChannelList channelList;
        public Channel Channel
        {
            get { return _channel; }
            set
            {
                _channel = value;
                this.lbl_ChannelName.Text = _channel.ChannelName;
                this.lbl_Alias.Text = _channel.Alias;
                this.cbb_Channel.Text = _channel.ChannelValue;
            }
        }

        public ChannelTag(ChannelList channelList, Model.Channel c)
        {
            InitializeComponent();
            this.channelList = channelList;
            this.Channel = c;
        }

        private void cbb_Channel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._channel.ChannelValue = this.cbb_Channel.SelectedText;
        }

        public void SetChannelSource(List<string> source)
        {
            var value = this.cbb_Channel.SelectedValue;
            this.cbb_Channel.DataSource = source;
            if (value != null && source.Contains(value.ToString()))
            {
                this.cbb_Channel.SelectedItem = value;
            }
        }
    }
}
