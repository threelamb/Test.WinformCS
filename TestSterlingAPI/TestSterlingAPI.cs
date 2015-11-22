using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestSterlingAPI.Component;

namespace TestSterlingAPI
{
    public partial class TestSterlingAPI : Form
    {
        public TestSterlingAPI()
        {
            InitializeComponent();
        }

        private void MenuItem_Order_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.panel_main.SuspendLayout();
            if (this.panel_main.Controls != null
                && this.panel_main.Controls.Count > 0)
            {
                this.panel_main.Controls.Clear();
            }

            Order orderForm = new Order();
            this.panel_main.Controls.Add(orderForm);
            orderForm.Dock = DockStyle.Fill;
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
