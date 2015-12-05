namespace Controls.Component
{
    partial class AccountList
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsb_addAccount = new System.Windows.Forms.ToolStripButton();
            this.tsb_deleteAccount = new System.Windows.Forms.ToolStripButton();
            this.tsb_accountDetail = new System.Windows.Forms.ToolStripButton();
            this.tsb_enableAccount = new System.Windows.Forms.ToolStripButton();
            this.tsb_disableAccount = new System.Windows.Forms.ToolStripButton();
            this.tsb_connectAccount = new System.Windows.Forms.ToolStripButton();
            this.tsb_disconnectAccount = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(219, 323);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.toolStrip2, 2);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_addAccount,
            this.tsb_deleteAccount,
            this.tsb_accountDetail,
            this.tsb_enableAccount,
            this.tsb_disableAccount,
            this.tsb_connectAccount,
            this.tsb_disconnectAccount,
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 30);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(219, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsb_addAccount
            // 
            this.tsb_addAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_addAccount.Image = global::Controls.Properties.Resources.Badge_plus_24px_1184722_easyicon_net;
            this.tsb_addAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_addAccount.Name = "tsb_addAccount";
            this.tsb_addAccount.Size = new System.Drawing.Size(23, 22);
            this.tsb_addAccount.Text = "toolStripButton1";
            this.tsb_addAccount.ToolTipText = "添加账户";
            // 
            // tsb_deleteAccount
            // 
            this.tsb_deleteAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_deleteAccount.Image = global::Controls.Properties.Resources.minus_24px_1088480_easyicon_net;
            this.tsb_deleteAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_deleteAccount.Name = "tsb_deleteAccount";
            this.tsb_deleteAccount.Size = new System.Drawing.Size(23, 22);
            this.tsb_deleteAccount.Text = "toolStripButton2";
            this.tsb_deleteAccount.ToolTipText = "删除账户";
            // 
            // tsb_accountDetail
            // 
            this.tsb_accountDetail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_accountDetail.Image = global::Controls.Properties.Resources.Exclamation_info_24px_529567_easyicon_net;
            this.tsb_accountDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_accountDetail.Name = "tsb_accountDetail";
            this.tsb_accountDetail.Size = new System.Drawing.Size(23, 22);
            this.tsb_accountDetail.Text = "toolStripButton3";
            this.tsb_accountDetail.ToolTipText = "查看账户";
            // 
            // tsb_enableAccount
            // 
            this.tsb_enableAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_enableAccount.Image = global::Controls.Properties.Resources.Badge_tick_24px_1184723_easyicon_net;
            this.tsb_enableAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_enableAccount.Name = "tsb_enableAccount";
            this.tsb_enableAccount.Size = new System.Drawing.Size(23, 22);
            this.tsb_enableAccount.Text = "toolStripButton4";
            this.tsb_enableAccount.ToolTipText = "启用账户";
            // 
            // tsb_disableAccount
            // 
            this.tsb_disableAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_disableAccount.Image = global::Controls.Properties.Resources.Badge_multiply_24px_1184721_easyicon_net;
            this.tsb_disableAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_disableAccount.Name = "tsb_disableAccount";
            this.tsb_disableAccount.Size = new System.Drawing.Size(23, 22);
            this.tsb_disableAccount.Text = "toolStripButton5";
            this.tsb_disableAccount.ToolTipText = "禁用账户";
            // 
            // tsb_connectAccount
            // 
            this.tsb_connectAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_connectAccount.Image = global::Controls.Properties.Resources.start_here_24px_572110_easyicon_net;
            this.tsb_connectAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_connectAccount.Name = "tsb_connectAccount";
            this.tsb_connectAccount.Size = new System.Drawing.Size(23, 22);
            this.tsb_connectAccount.Text = "toolStripButton3";
            this.tsb_connectAccount.ToolTipText = "连接";
            // 
            // tsb_disconnectAccount
            // 
            this.tsb_disconnectAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_disconnectAccount.Image = global::Controls.Properties.Resources.Player_Pause_24px_523867_easyicon_net;
            this.tsb_disconnectAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_disconnectAccount.Name = "tsb_disconnectAccount";
            this.tsb_disconnectAccount.Size = new System.Drawing.Size(23, 22);
            this.tsb_disconnectAccount.Text = "toolStripButton4";
            this.tsb_disconnectAccount.ToolTipText = "断开";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "交易账户";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Controls.Properties.Resources.Badge_multiply_24px_1184721_easyicon_net;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // AccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AccountList";
            this.Size = new System.Drawing.Size(219, 323);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsb_addAccount;
        private System.Windows.Forms.ToolStripButton tsb_deleteAccount;
        private System.Windows.Forms.ToolStripButton tsb_accountDetail;
        private System.Windows.Forms.ToolStripButton tsb_enableAccount;
        private System.Windows.Forms.ToolStripButton tsb_disableAccount;
        private System.Windows.Forms.ToolStripButton tsb_connectAccount;
        private System.Windows.Forms.ToolStripButton tsb_disconnectAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
