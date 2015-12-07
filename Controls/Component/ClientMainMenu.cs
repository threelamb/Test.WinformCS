using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controls.Component.Channel;

namespace Controls.Component
{
    public partial class ClientMainMenu : UserControl
    {
        public ClientMainMenu()
        {
            InitializeComponent();
        }

        private void 通道别名设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChannelAliasSetting().ShowDialog();
        }
    }
}
