namespace Controls.Component
{
    partial class ChannelTag
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
            this.lbl_ChannelName = new System.Windows.Forms.Label();
            this.lbl_Alias = new System.Windows.Forms.Label();
            this.cbb_Channel = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_ChannelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Alias, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbb_Channel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 30);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_ChannelName
            // 
            this.lbl_ChannelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ChannelName.AutoSize = true;
            this.lbl_ChannelName.Location = new System.Drawing.Point(3, 9);
            this.lbl_ChannelName.Name = "lbl_ChannelName";
            this.lbl_ChannelName.Size = new System.Drawing.Size(74, 12);
            this.lbl_ChannelName.TabIndex = 0;
            this.lbl_ChannelName.Text = "通用通道1";
            // 
            // lbl_Alias
            // 
            this.lbl_Alias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Alias.AutoSize = true;
            this.lbl_Alias.Location = new System.Drawing.Point(83, 9);
            this.lbl_Alias.Name = "lbl_Alias";
            this.lbl_Alias.Size = new System.Drawing.Size(74, 12);
            this.lbl_Alias.TabIndex = 0;
            this.lbl_Alias.Text = "通用通道1";
            // 
            // cbb_Channel
            // 
            this.cbb_Channel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_Channel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Channel.FormattingEnabled = true;
            this.cbb_Channel.Location = new System.Drawing.Point(163, 5);
            this.cbb_Channel.Name = "cbb_Channel";
            this.cbb_Channel.Size = new System.Drawing.Size(94, 20);
            this.cbb_Channel.TabIndex = 1;
            // 
            // ChannelTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ChannelTag";
            this.Size = new System.Drawing.Size(292, 30);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_ChannelName;
        private System.Windows.Forms.Label lbl_Alias;
        private System.Windows.Forms.ComboBox cbb_Channel;
    }
}
