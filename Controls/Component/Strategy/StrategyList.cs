using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controls.Component
{
    public partial class StrategyList : UserControl
    {
        public StrategyList()
        {
            InitializeComponent();
        }

        private void tsb_AddStrategy_Click(object sender, EventArgs e)
        {
            new StrategySetting().Show();
        }
    }
}
