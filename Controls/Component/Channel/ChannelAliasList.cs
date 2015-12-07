using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace Controls.Component.Channel
{
    public partial class ChannelAliasList : UserControl
    {
        List<ChannelAliasTag> ItemList = new List<ChannelAliasTag>();
        private List<KeyValuePair<string, ChannelAliasModel>> list;
        public ChannelAliasList(List<ChannelAliasModel> model)
        {
            InitializeComponent();
            int i = 0;
            foreach (var itemModel in model)
            {
                var ItemUI = new ChannelAliasTag();
                ItemUI.Data = itemModel;
                ItemList.Add(ItemUI);
                ItemUI.Dock = System.Windows.Forms.DockStyle.Fill;
                ItemUI.Name = "ItemUI" + (i.ToString());
                this.tlp_ChannelList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
                this.tlp_ChannelList.Controls.Add(ItemUI, 0, i);
                i++;
                ItemUI.TabIndex = i;
            }
            this.tlp_ChannelList.RowStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ChannelList.RowCount = i + 1;
        }

        public Dictionary<string, ChannelAliasModel> GetAliasList()
        {
            var res = new Dictionary<string, ChannelAliasModel>();
            foreach (var item in ItemList)
            {
                var temp = item.GetAlias();
                res.Add(temp.ChannelName, temp);
            }
            return res;
        }
    }
}
