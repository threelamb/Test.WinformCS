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
        private List<ChannelModel> list;
        private bool p;
        public ChannelTag Current { get; set; }

        public ChannelList(List<ChannelModel> channelList, bool IsCD)
        {
            InitializeComponent();

            SetIsCD(channelList, IsCD);
            SetChannelList(channelList);
        }

        private void SetIsCD(List<ChannelModel> channelList, bool IsCD)
        {
            foreach (var item in channelList)
            {
                item.IsCDChannel = IsCD;
            }
        }

        public List<ChannelModel> GetChannelList()
        {
            return ItemList.Select(o => o.Channel).ToList();
        }

        public void SetChannelList(List<ChannelModel> channelList)
        {
            int i = 0;
            foreach (var itemModel in channelList)
            {
                ChannelTag ItemUI = new ChannelTag(this, itemModel);
                ItemList.Add(ItemUI);
                ItemUI.Dock = System.Windows.Forms.DockStyle.Fill;
                ItemUI.Name = "ItemUI" + (i.ToString());
                this.tlp_ChannelList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
                this.tlp_ChannelList.Controls.Add(ItemUI, 0, i);
                i++;
                ItemUI.TabIndex = i;

                Current = ItemUI;
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
