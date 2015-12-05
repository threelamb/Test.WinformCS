using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controls
{
    public partial class ItraderMain : Form
    {
        public ItraderMain()
        {
            InitializeComponent();
            this.Text = Resource.Resource.txt_itraderMain;
        }

        private void ItraderMain_Load(object sender, EventArgs e)
        {
            var res = new Login().ShowDialog();
            if (res != System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
