using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Common;

namespace Controls.Component
{
    public partial class ChannelList : UserControl
    {
        List<ChannelTag> ItemList = new List<ChannelTag>();
        public ChannelTag Current { get; set; }

        public ChannelList(List<Channel> channelList)
        {
            InitializeComponent();
            SetChannelList(channelList);
        }

        public List<Channel> GetChannelList()
        {
            return ItemList.Select(o => o.Channel).ToList();
        }

        public void SetChannelList(List<Channel> channelList)
        {
            int i = 0;
            foreach (var item in channelList)
            {
                ChannelTag accountTag = new ChannelTag(this, item);
                ItemList.Add(accountTag);
                accountTag.Dock = System.Windows.Forms.DockStyle.Fill;
                accountTag.Name = "accountTag" + (i.ToString());
                this.tlp_ChannelList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
                this.tlp_ChannelList.Controls.Add(accountTag, 0, i);
                i++;
                accountTag.TabIndex = i;

                Current = accountTag;
            }
        }

        public void RemoveItem()
        {
            this.ItemList.Remove(this.Current);
            this.tlp_ChannelList.Controls.Remove(this.Current);
            this.Current = (ChannelTag)this.tlp_ChannelList.Controls[this.tlp_ChannelList.Controls.Count];
        }

        internal void SetChannelSource(List<string> source)
        {
            foreach (var item in ItemList)
            {
                item.SetChannelSource(source.Clone());
            }
        }
    }
}
