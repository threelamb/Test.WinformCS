using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Controls.Component;

namespace Controls.Component
{
    public partial class StrategySetting : Form
    {
        public StrategySetting()
        {
            InitializeComponent();
        }

        public StrategyModel strategy;

        private void btn_Add_Click(object sender, EventArgs e)
        {
            switch (this.cbx_Commend.SelectedItem.ToString())
            {
                default:
                    break;
            }
        }

        private void btn_UP_Click(object sender, EventArgs e)
        {

        }

        private void btn_Down_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delelte_Click(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
