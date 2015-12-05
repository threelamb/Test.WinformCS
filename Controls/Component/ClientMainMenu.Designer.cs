namespace Controls.Component
{
    partial class ClientMainMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.交易ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_bindForm = new System.Windows.Forms.ToolStripButton();
            this.tsb_refreshBind = new System.Windows.Forms.ToolStripButton();
            this.tsl_bindFormCount = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.用户ToolStripMenuItem,
            this.交易ToolStripMenuItem,
            this.窗口ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(365, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem1.Text = "系统";
            // 
            // 用户ToolStripMenuItem
            // 
            this.用户ToolStripMenuItem.Name = "用户ToolStripMenuItem";
            this.用户ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.用户ToolStripMenuItem.Text = "用户";
            // 
            // 交易ToolStripMenuItem
            // 
            this.交易ToolStripMenuItem.Name = "交易ToolStripMenuItem";
            this.交易ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.交易ToolStripMenuItem.Text = "交易";
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.窗口ToolStripMenuItem.Text = "窗口";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_bindForm,
            this.tsb_refreshBind,
            this.tsl_bindFormCount});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(365, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_bindForm
            // 
            this.tsb_bindForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_bindForm.Image = global::Controls.Properties.Resources.Magic_wand_24px_1185779_easyicon_net;
            this.tsb_bindForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_bindForm.Name = "tsb_bindForm";
            this.tsb_bindForm.Size = new System.Drawing.Size(23, 22);
            this.tsb_bindForm.Text = "连接所有2级窗口";
            // 
            // tsb_refreshBind
            // 
            this.tsb_refreshBind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_refreshBind.Image = global::Controls.Properties.Resources.refresh_24px_1096680_easyicon_net;
            this.tsb_refreshBind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_refreshBind.Name = "tsb_refreshBind";
            this.tsb_refreshBind.Size = new System.Drawing.Size(23, 22);
            this.tsb_refreshBind.Text = "刷新";
            // 
            // tsl_bindFormCount
            // 
            this.tsl_bindFormCount.Name = "tsl_bindFormCount";
            this.tsl_bindFormCount.Size = new System.Drawing.Size(15, 22);
            this.tsl_bindFormCount.Text = "0";
            // 
            // ClientMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ClientMainMenu";
            this.Size = new System.Drawing.Size(365, 49);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 交易ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_bindForm;
        private System.Windows.Forms.ToolStripButton tsb_refreshBind;
        private System.Windows.Forms.ToolStripLabel tsl_bindFormCount;
    }
}
