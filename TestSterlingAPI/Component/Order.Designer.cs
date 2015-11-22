namespace TestSterlingAPI.Component
{
    partial class Order
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
            this.tbx_Symbol = new System.Windows.Forms.TextBox();
            this.lbl_Symbol = new System.Windows.Forms.Label();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.tbx_Account = new System.Windows.Forms.TextBox();
            this.lbl_PriceType = new System.Windows.Forms.Label();
            this.cbx_PriceType = new System.Windows.Forms.ComboBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.tbx_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Tif = new System.Windows.Forms.Label();
            this.lbl_Destination = new System.Windows.Forms.Label();
            this.cbx_Tif = new System.Windows.Forms.ComboBox();
            this.cbx_Destination = new System.Windows.Forms.ComboBox();
            this.btn_Shrt = new System.Windows.Forms.Button();
            this.btn_Sell = new System.Windows.Forms.Button();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_PriceType, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbx_Account, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Account, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbx_Symbol, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Symbol, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbx_PriceType, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Quantity, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbx_Quantity, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Tif, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Destination, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbx_Tif, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbx_Destination, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Shrt, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Sell, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Buy, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 251);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbx_Symbol
            // 
            this.tbx_Symbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_Symbol.Location = new System.Drawing.Point(87, 31);
            this.tbx_Symbol.Name = "tbx_Symbol";
            this.tbx_Symbol.Size = new System.Drawing.Size(78, 21);
            this.tbx_Symbol.TabIndex = 0;
            this.tbx_Symbol.Text = "SIRI";
            // 
            // lbl_Symbol
            // 
            this.lbl_Symbol.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Symbol.AutoSize = true;
            this.lbl_Symbol.Location = new System.Drawing.Point(28, 35);
            this.lbl_Symbol.Name = "lbl_Symbol";
            this.lbl_Symbol.Size = new System.Drawing.Size(53, 12);
            this.lbl_Symbol.TabIndex = 1;
            this.lbl_Symbol.Text = "股票名称";
            // 
            // lbl_Account
            // 
            this.lbl_Account.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Location = new System.Drawing.Point(220, 35);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(29, 12);
            this.lbl_Account.TabIndex = 2;
            this.lbl_Account.Text = "账户";
            // 
            // tbx_Account
            // 
            this.tbx_Account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_Account.Location = new System.Drawing.Point(255, 31);
            this.tbx_Account.Name = "tbx_Account";
            this.tbx_Account.Size = new System.Drawing.Size(78, 21);
            this.tbx_Account.TabIndex = 3;
            this.tbx_Account.Text = "IF030LPWA";
            // 
            // lbl_PriceType
            // 
            this.lbl_PriceType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_PriceType.AutoSize = true;
            this.lbl_PriceType.Location = new System.Drawing.Point(364, 35);
            this.lbl_PriceType.Name = "lbl_PriceType";
            this.lbl_PriceType.Size = new System.Drawing.Size(53, 12);
            this.lbl_PriceType.TabIndex = 4;
            this.lbl_PriceType.Text = "价格类型";
            // 
            // cbx_PriceType
            // 
            this.cbx_PriceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_PriceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_PriceType.FormattingEnabled = true;
            this.cbx_PriceType.Location = new System.Drawing.Point(423, 31);
            this.cbx_PriceType.Name = "cbx_PriceType";
            this.cbx_PriceType.Size = new System.Drawing.Size(78, 20);
            this.cbx_PriceType.TabIndex = 5;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Location = new System.Drawing.Point(52, 118);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(29, 12);
            this.lbl_Quantity.TabIndex = 7;
            this.lbl_Quantity.Text = "数量";
            // 
            // tbx_Quantity
            // 
            this.tbx_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_Quantity.Location = new System.Drawing.Point(87, 114);
            this.tbx_Quantity.Name = "tbx_Quantity";
            this.tbx_Quantity.Size = new System.Drawing.Size(78, 21);
            this.tbx_Quantity.TabIndex = 8;
            this.tbx_Quantity.Text = "100";
            // 
            // lbl_Tif
            // 
            this.lbl_Tif.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Tif.AutoSize = true;
            this.lbl_Tif.Location = new System.Drawing.Point(220, 118);
            this.lbl_Tif.Name = "lbl_Tif";
            this.lbl_Tif.Size = new System.Drawing.Size(29, 12);
            this.lbl_Tif.TabIndex = 9;
            this.lbl_Tif.Text = "时间";
            // 
            // lbl_Destination
            // 
            this.lbl_Destination.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Destination.AutoSize = true;
            this.lbl_Destination.Location = new System.Drawing.Point(388, 118);
            this.lbl_Destination.Name = "lbl_Destination";
            this.lbl_Destination.Size = new System.Drawing.Size(29, 12);
            this.lbl_Destination.TabIndex = 9;
            this.lbl_Destination.Text = "通道";
            // 
            // cbx_Tif
            // 
            this.cbx_Tif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Tif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Tif.FormattingEnabled = true;
            this.cbx_Tif.Location = new System.Drawing.Point(255, 114);
            this.cbx_Tif.Name = "cbx_Tif";
            this.cbx_Tif.Size = new System.Drawing.Size(78, 20);
            this.cbx_Tif.TabIndex = 11;
            // 
            // cbx_Destination
            // 
            this.cbx_Destination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Destination.FormattingEnabled = true;
            this.cbx_Destination.Location = new System.Drawing.Point(423, 114);
            this.cbx_Destination.Name = "cbx_Destination";
            this.cbx_Destination.Size = new System.Drawing.Size(78, 20);
            this.cbx_Destination.TabIndex = 5;
            // 
            // btn_Shrt
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_Shrt, 2);
            this.btn_Shrt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Shrt.Location = new System.Drawing.Point(3, 169);
            this.btn_Shrt.Name = "btn_Shrt";
            this.btn_Shrt.Size = new System.Drawing.Size(162, 79);
            this.btn_Shrt.TabIndex = 12;
            this.btn_Shrt.Text = "SHRT";
            this.btn_Shrt.UseVisualStyleBackColor = true;
            this.btn_Shrt.Click += new System.EventHandler(this.btn_Shrt_Click);
            // 
            // btn_Sell
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_Sell, 2);
            this.btn_Sell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Sell.Location = new System.Drawing.Point(171, 169);
            this.btn_Sell.Name = "btn_Sell";
            this.btn_Sell.Size = new System.Drawing.Size(162, 79);
            this.btn_Sell.TabIndex = 13;
            this.btn_Sell.Text = "SELL";
            this.btn_Sell.UseVisualStyleBackColor = true;
            this.btn_Sell.Click += new System.EventHandler(this.btn_Sell_Click);
            // 
            // btn_Buy
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_Buy, 2);
            this.btn_Buy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Buy.Location = new System.Drawing.Point(339, 169);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(162, 79);
            this.btn_Buy.TabIndex = 14;
            this.btn_Buy.Text = "BUY";
            this.btn_Buy.UseVisualStyleBackColor = true;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(504, 251);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbx_Tif;
        private System.Windows.Forms.Label lbl_PriceType;
        private System.Windows.Forms.TextBox tbx_Account;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.TextBox tbx_Symbol;
        private System.Windows.Forms.Label lbl_Symbol;
        private System.Windows.Forms.ComboBox cbx_PriceType;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox tbx_Quantity;
        private System.Windows.Forms.Label lbl_Tif;
        private System.Windows.Forms.Label lbl_Destination;
        private System.Windows.Forms.ComboBox cbx_Destination;
        private System.Windows.Forms.Button btn_Shrt;
        private System.Windows.Forms.Button btn_Sell;
        private System.Windows.Forms.Button btn_Buy;
    }
}
