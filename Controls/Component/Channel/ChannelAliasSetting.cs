using ClientBusiness.User;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controls.Component.Channel
{
    public partial class ChannelAliasSetting : Form
    {

        ChannelAliasList normalChannels = new ChannelAliasList(UserModel.Current.ChannelSetting.TYChannelList.Values.ToList());

        public ChannelAliasSetting()
        {
            InitializeComponent();

            normalChannels.Dock = DockStyle.Fill;
            this.tabPage1.Controls.Add(normalChannels);
        }
    }
}
