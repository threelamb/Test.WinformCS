namespace Controls.Component
{
    partial class StrategyList
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
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tsb_AddStrategy = new System.Windows.Forms.ToolStripButton();
            this.tsb_DeleteStrategy = new System.Windows.Forms.ToolStripButton();
            this.tsb_EditeStrategy = new System.Windows.Forms.ToolStripButton();
            this.tsb_EnableStrategy = new System.Windows.Forms.ToolStripButton();
            this.tsb_DisableStrategy = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UniqueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortcutKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrategyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 269);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_AddStrategy,
            this.tsb_DeleteStrategy,
            this.tsb_EditeStrategy,
            this.tsb_EnableStrategy,
            this.tsb_DisableStrategy});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(282, 25);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tsb_AddStrategy
            // 
            this.tsb_AddStrategy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_AddStrategy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AddStrategy.Name = "tsb_AddStrategy";
            this.tsb_AddStrategy.Size = new System.Drawing.Size(23, 22);
            this.tsb_AddStrategy.ToolTipText = "添加策略";
            this.tsb_AddStrategy.Click += new System.EventHandler(this.tsb_AddStrategy_Click);
            // 
            // tsb_DeleteStrategy
            // 
            this.tsb_DeleteStrategy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_DeleteStrategy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_DeleteStrategy.Name = "tsb_DeleteStrategy";
            this.tsb_DeleteStrategy.Size = new System.Drawing.Size(23, 22);
            this.tsb_DeleteStrategy.Text = "toolStripButton2";
            this.tsb_DeleteStrategy.ToolTipText = "删除策略";
            // 
            // tsb_EditeStrategy
            // 
            this.tsb_EditeStrategy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_EditeStrategy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_EditeStrategy.Name = "tsb_EditeStrategy";
            this.tsb_EditeStrategy.Size = new System.Drawing.Size(23, 22);
            this.tsb_EditeStrategy.Text = "toolStripButton3";
            this.tsb_EditeStrategy.ToolTipText = "编辑策略";
            // 
            // tsb_EnableStrategy
            // 
            this.tsb_EnableStrategy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_EnableStrategy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_EnableStrategy.Name = "tsb_EnableStrategy";
            this.tsb_EnableStrategy.Size = new System.Drawing.Size(23, 22);
            this.tsb_EnableStrategy.Text = "toolStripButton4";
            this.tsb_EnableStrategy.ToolTipText = "启用策略";
            // 
            // tsb_DisableStrategy
            // 
            this.tsb_DisableStrategy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_DisableStrategy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_DisableStrategy.Name = "tsb_DisableStrategy";
            this.tsb_DisableStrategy.Size = new System.Drawing.Size(23, 22);
            this.tsb_DisableStrategy.Text = "toolStripButton5";
            this.tsb_DisableStrategy.ToolTipText = "禁用策略";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UniqueID,
            this.ShortcutKey,
            this.Status,
            this.StrategyName,
            this.Description});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(276, 233);
            this.dataGridView1.TabIndex = 3;
            // 
            // UniqueID
            // 
            this.UniqueID.HeaderText = "唯一标识";
            this.UniqueID.Name = "UniqueID";
            this.UniqueID.ReadOnly = true;
            this.UniqueID.Visible = false;
            // 
            // ShortcutKey
            // 
            this.ShortcutKey.HeaderText = "快捷键";
            this.ShortcutKey.Name = "ShortcutKey";
            this.ShortcutKey.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // StrategyName
            // 
            this.StrategyName.HeaderText = "策略名称";
            this.StrategyName.Name = "StrategyName";
            this.StrategyName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "策略描述";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // StrategyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StrategyList";
            this.Size = new System.Drawing.Size(282, 269);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tsb_AddStrategy;
        private System.Windows.Forms.ToolStripButton tsb_DeleteStrategy;
        private System.Windows.Forms.ToolStripButton tsb_EditeStrategy;
        private System.Windows.Forms.ToolStripButton tsb_EnableStrategy;
        private System.Windows.Forms.ToolStripButton tsb_DisableStrategy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniqueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortcutKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrategyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;

    }
}
