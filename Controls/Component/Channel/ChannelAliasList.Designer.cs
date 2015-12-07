namespace Controls.Component.Channel
{
    partial class ChannelAliasList
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
            this.tlp_ChannelList = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tlp_ChannelList
            // 
            this.tlp_ChannelList.AutoScroll = true;
            this.tlp_ChannelList.BackColor = System.Drawing.Color.White;
            this.tlp_ChannelList.ColumnCount = 1;
            this.tlp_ChannelList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_ChannelList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ChannelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ChannelList.Location = new System.Drawing.Point(0, 0);
            this.tlp_ChannelList.Name = "tlp_ChannelList";
            this.tlp_ChannelList.Size = new System.Drawing.Size(316, 293);
            this.tlp_ChannelList.TabIndex = 1;
            // 
            // ChannelAliasList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_ChannelList);
            this.Name = "ChannelAliasList";
            this.Size = new System.Drawing.Size(316, 293);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_ChannelList;
    }
}
