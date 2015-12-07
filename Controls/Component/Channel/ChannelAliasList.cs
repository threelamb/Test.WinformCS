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
        int count = 10;
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

                ItemList.Add(ItemUI);
                ItemUI.Dock = System.Windows.Forms.DockStyle.Fill;
                ItemUI.Name = "ItemUI" + (i.ToString());
                this.tlp_ChannelList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
                this.tlp_ChannelList.Controls.Add(ItemUI, 0, i);
                i++;
                ItemUI.TabIndex = i;
            }
        }

        public List<ChannelAliasModel> GetAliasList()
        {
            List<ChannelAliasModel> res = new List<ChannelAliasModel>();
            foreach (var item in ItemList)
            {
                res.Add(item.GetAlias());
            }
            return res;
        }
    }
}
