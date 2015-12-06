namespace Controls.Component
{
    partial class AccountTag
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
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.lbl_Alias = new System.Windows.Forms.Label();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Status, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_IP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Alias, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Account, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 86);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Status
            // 
            this.lbl_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(125, 58);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(116, 12);
            this.lbl_Status.TabIndex = 3;
            this.lbl_Status.Text = "label1";
            // 
            // lbl_IP
            // 
            this.lbl_IP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Location = new System.Drawing.Point(3, 58);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(116, 12);
            this.lbl_IP.TabIndex = 2;
            this.lbl_IP.Text = "label1";
            // 
            // lbl_Alias
            // 
            this.lbl_Alias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Alias.AutoSize = true;
            this.lbl_Alias.Location = new System.Drawing.Point(125, 15);
            this.lbl_Alias.Name = "lbl_Alias";
            this.lbl_Alias.Size = new System.Drawing.Size(116, 12);
            this.lbl_Alias.TabIndex = 1;
            this.lbl_Alias.Text = "label1";
            // 
            // lbl_Account
            // 
            this.lbl_Account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Location = new System.Drawing.Point(3, 15);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(116, 12);
            this.lbl_Account.TabIndex = 0;
            this.lbl_Account.Text = "label1";
            // 
            // AccountTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AccountTag";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(248, 90);
            this.Click += new System.EventHandler(this.AccountTag_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.Label lbl_Alias;
        private System.Windows.Forms.Label lbl_Account;



    }
}
