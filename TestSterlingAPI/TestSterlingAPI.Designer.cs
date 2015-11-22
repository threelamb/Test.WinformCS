namespace TestSterlingAPI
{
    partial class TestSterlingAPI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestSterlingAPI));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menu_operation = new System.Windows.Forms.ToolStripSplitButton();
            this.MenuItem_Order = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Destination = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Account = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_main = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_operation});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(712, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menu_operation
            // 
            this.menu_operation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu_operation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Order,
            this.MenuItem_Destination,
            this.MenuItem_Account});
            this.menu_operation.Image = ((System.Drawing.Image)(resources.GetObject("menu_operation.Image")));
            this.menu_operation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_operation.Name = "menu_operation";
            this.menu_operation.Size = new System.Drawing.Size(48, 22);
            this.menu_operation.Text = "操作";
            // 
            // MenuItem_Order
            // 
            this.MenuItem_Order.Name = "MenuItem_Order";
            this.MenuItem_Order.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_Order.Text = "订单";
            this.MenuItem_Order.Click += new System.EventHandler(this.MenuItem_Order_Click);
            // 
            // MenuItem_Destination
            // 
            this.MenuItem_Destination.Name = "MenuItem_Destination";
            this.MenuItem_Destination.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_Destination.Text = "通道";
            // 
            // MenuItem_Account
            // 
            this.MenuItem_Account.Name = "MenuItem_Account";
            this.MenuItem_Account.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_Account.Text = "账户";
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.Control;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 25);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(712, 255);
            this.panel_main.TabIndex = 1;
            // 
            // TestSterlingAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 280);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TestSterlingAPI";
            this.Text = "TestSterlingAPI";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton menu_operation;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Order;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Destination;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Account;
        private System.Windows.Forms.Panel panel_main;



    }
}

