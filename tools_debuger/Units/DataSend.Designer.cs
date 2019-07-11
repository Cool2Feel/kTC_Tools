namespace LeafSoft.Units
{
    partial class DataSend
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgCMD = new System.Windows.Forms.DataGridView();
            this.IsAutoSend = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMDText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMDTips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSend = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Saved = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Input = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAutoSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nmDelay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.LinkLabel();
            this.emi_Label1 = new EASkins.Emi_Label();
            this.openFileRead = new System.Windows.Forms.OpenFileDialog();
            this.saveFileInit = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCMD)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCMD
            // 
            this.dgCMD.AllowUserToAddRows = false;
            this.dgCMD.AllowUserToDeleteRows = false;
            this.dgCMD.AllowUserToResizeColumns = false;
            this.dgCMD.AllowUserToResizeRows = false;
            this.dgCMD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCMD.BackgroundColor = System.Drawing.Color.White;
            this.dgCMD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgCMD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgCMD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCMD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsAutoSend,
            this.CType,
            this.CMDText,
            this.CMDTips,
            this.btnSend});
            this.dgCMD.ContextMenuStrip = this.contextMenuStrip1;
            this.dgCMD.Location = new System.Drawing.Point(0, 0);
            this.dgCMD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgCMD.MultiSelect = false;
            this.dgCMD.Name = "dgCMD";
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgCMD.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgCMD.RowHeadersVisible = false;
            this.dgCMD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgCMD.RowTemplate.Height = 23;
            this.dgCMD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCMD.Size = new System.Drawing.Size(597, 228);
            this.dgCMD.TabIndex = 0;
            this.dgCMD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCMD_CellContentClick);
            this.dgCMD.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dgCMD_CellToolTipTextNeeded);
            this.dgCMD.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgCMD_RowsAdded);
            // 
            // IsAutoSend
            // 
            this.IsAutoSend.HeaderText = "参与循环";
            this.IsAutoSend.Name = "IsAutoSend";
            this.IsAutoSend.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsAutoSend.Width = 70;
            // 
            // CType
            // 
            this.CType.DataPropertyName = "ContentTypeName";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CType.DefaultCellStyle = dataGridViewCellStyle16;
            this.CType.HeaderText = "类型";
            this.CType.Name = "CType";
            this.CType.ReadOnly = true;
            this.CType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CType.Width = 60;
            // 
            // CMDText
            // 
            this.CMDText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CMDText.DataPropertyName = "Text";
            this.CMDText.HeaderText = "命令";
            this.CMDText.Name = "CMDText";
            this.CMDText.ReadOnly = true;
            this.CMDText.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CMDTips
            // 
            this.CMDTips.DataPropertyName = "Tips";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CMDTips.DefaultCellStyle = dataGridViewCellStyle19;
            this.CMDTips.HeaderText = "备注";
            this.CMDTips.Name = "CMDTips";
            this.CMDTips.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CMDTips.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CMDTips.Width = 70;
            // 
            // btnSend
            // 
            this.btnSend.HeaderText = "发送";
            this.btnSend.Name = "btnSend";
            this.btnSend.ReadOnly = true;
            this.btnSend.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnSend.Text = "发送";
            this.btnSend.Width = 80;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Add,
            this.MS_Edit,
            this.MS_Delete,
            this.MS_Saved,
            this.MS_Input,
            this.MS_SaveAs});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 136);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // MS_Add
            // 
            this.MS_Add.Name = "MS_Add";
            this.MS_Add.Size = new System.Drawing.Size(124, 22);
            this.MS_Add.Text = "添加";
            this.MS_Add.Click += new System.EventHandler(this.MS_Add_Click);
            // 
            // MS_Edit
            // 
            this.MS_Edit.Name = "MS_Edit";
            this.MS_Edit.Size = new System.Drawing.Size(124, 22);
            this.MS_Edit.Text = "编辑";
            this.MS_Edit.Click += new System.EventHandler(this.MS_Edit_Click);
            // 
            // MS_Delete
            // 
            this.MS_Delete.Name = "MS_Delete";
            this.MS_Delete.Size = new System.Drawing.Size(124, 22);
            this.MS_Delete.Text = "删除";
            this.MS_Delete.Click += new System.EventHandler(this.MS_Delete_Click);
            // 
            // MS_Saved
            // 
            this.MS_Saved.Name = "MS_Saved";
            this.MS_Saved.Size = new System.Drawing.Size(124, 22);
            this.MS_Saved.Text = "默认保存";
            this.MS_Saved.Visible = false;
            this.MS_Saved.Click += new System.EventHandler(this.MS_Saved_Click);
            // 
            // MS_Input
            // 
            this.MS_Input.Name = "MS_Input";
            this.MS_Input.Size = new System.Drawing.Size(124, 22);
            this.MS_Input.Text = "导入指令";
            this.MS_Input.Click += new System.EventHandler(this.MS_Input_Click);
            // 
            // MS_SaveAs
            // 
            this.MS_SaveAs.Name = "MS_SaveAs";
            this.MS_SaveAs.Size = new System.Drawing.Size(124, 22);
            this.MS_SaveAs.Text = "导出保存";
            this.MS_SaveAs.Click += new System.EventHandler(this.MS_SaveAs_Click);
            // 
            // btnAutoSend
            // 
            this.btnAutoSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAutoSend.Location = new System.Drawing.Point(7, 232);
            this.btnAutoSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAutoSend.Name = "btnAutoSend";
            this.btnAutoSend.Size = new System.Drawing.Size(100, 30);
            this.btnAutoSend.TabIndex = 1;
            this.btnAutoSend.Text = "循环发送";
            this.btnAutoSend.UseVisualStyleBackColor = true;
            this.btnAutoSend.Click += new System.EventHandler(this.btnAutoSend_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "发送间隔(>10)：";
            // 
            // nmDelay
            // 
            this.nmDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nmDelay.Location = new System.Drawing.Point(215, 236);
            this.nmDelay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmDelay.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmDelay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmDelay.Name = "nmDelay";
            this.nmDelay.Size = new System.Drawing.Size(82, 23);
            this.nmDelay.TabIndex = 3;
            this.nmDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmDelay_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "毫秒(ms)";
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(439, 239);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(15, 17);
            this.lblCount.TabIndex = 8;
            this.lblCount.TabStop = true;
            this.lblCount.Text = "0";
            this.lblCount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCount_LinkClicked);
            // 
            // emi_Label1
            // 
            this.emi_Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.emi_Label1.AutoSize = true;
            this.emi_Label1.BackColor = System.Drawing.Color.Transparent;
            this.emi_Label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emi_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emi_Label1.Location = new System.Drawing.Point(357, 239);
            this.emi_Label1.Name = "emi_Label1";
            this.emi_Label1.Size = new System.Drawing.Size(80, 17);
            this.emi_Label1.TabIndex = 9;
            this.emi_Label1.Text = "发送字节数：";
            this.emi_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.ShowAlways = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(477, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "提示：右键指令操作";
            // 
            // DataSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emi_Label1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmDelay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAutoSend);
            this.Controls.Add(this.dgCMD);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DataSend";
            this.Size = new System.Drawing.Size(597, 266);
            this.Load += new System.EventHandler(this.DataSend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCMD)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCMD;
        private System.Windows.Forms.Button btnAutoSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_Add;
        private System.Windows.Forms.ToolStripMenuItem MS_Edit;
        private System.Windows.Forms.ToolStripMenuItem MS_Delete;
        private System.Windows.Forms.LinkLabel lblCount;
        private EASkins.Emi_Label emi_Label1;
        private System.Windows.Forms.OpenFileDialog openFileRead;
        private System.Windows.Forms.SaveFileDialog saveFileInit;
        private System.Windows.Forms.ToolStripMenuItem MS_Saved;
        private System.Windows.Forms.ToolStripMenuItem MS_Input;
        private System.Windows.Forms.ToolStripMenuItem MS_SaveAs;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAutoSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn CType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMDText;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMDTips;
        private System.Windows.Forms.DataGridViewButtonColumn btnSend;
    }
}
