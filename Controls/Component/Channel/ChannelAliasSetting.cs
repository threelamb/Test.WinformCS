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

        ChannelAliasList TYChannels = new ChannelAliasList(UserModel.Current.ChannelSetting.TYChannelList.Values.ToList());
        ChannelAliasList CDChannels = new ChannelAliasList(UserModel.Current.ChannelSetting.CDChannelList.Values.ToList());

        public ChannelAliasSetting()
        {
            InitializeComponent();

            TYChannels.Dock = DockStyle.Fill;
            this.tabPage1.Controls.Add(TYChannels);

            CDChannels.Dock = DockStyle.Fill;
            this.tabPage2.Controls.Add(CDChannels);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            UserModel.Current.ChannelSetting.TYChannelList = this.TYChannels.GetAliasList();
            UserModel.Current.ChannelSetting.CDChannelList = this.CDChannels.GetAliasList();
            new UserBuz().Save();
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
