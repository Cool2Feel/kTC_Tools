namespace LeafSoft.PartPanel
{
    partial class WOLPanel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btWake = new CCWin.SkinControl.SkinButton();
            this.MacTextBox = new IpBoxControl.MACTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btMac = new System.Windows.Forms.Button();
            this.btAllsend = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgWOL = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bt_Eidt = new System.Windows.Forms.Button();
            this.MS_add = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_eidt = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_wake = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_getMac = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_select = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.IsAutoSend = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CMac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMDName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMDIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSend = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWOL)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btWake);
            this.panel1.Controls.Add(this.MacTextBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 83);
            this.panel1.TabIndex = 0;
            // 
            // btWake
            // 
            this.btWake.BackColor = System.Drawing.Color.Transparent;
            this.btWake.BaseColor = System.Drawing.Color.Silver;
            this.btWake.BorderColor = System.Drawing.Color.Gray;
            this.btWake.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btWake.DownBack = null;
            this.btWake.DownBaseColor = System.Drawing.Color.Gray;
            this.btWake.Location = new System.Drawing.Point(364, 10);
            this.btWake.MouseBack = null;
            this.btWake.MouseBaseColor = System.Drawing.Color.Silver;
            this.btWake.Name = "btWake";
            this.btWake.NormlBack = null;
            this.btWake.Size = new System.Drawing.Size(90, 28);
            this.btWake.TabIndex = 27;
            this.btWake.Text = "广播唤醒";
            this.btWake.UseVisualStyleBackColor = false;
            this.btWake.Click += new System.EventHandler(this.button1_Click);
            // 
            // MacTextBox
            // 
            this.MacTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MacTextBox.Location = new System.Drawing.Point(177, 11);
            this.MacTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MacTextBox.Name = "MacTextBox";
            this.MacTextBox.Size = new System.Drawing.Size(170, 26);
            this.MacTextBox.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bt_Eidt);
            this.panel2.Controls.Add(this.btMac);
            this.panel2.Controls.Add(this.btAllsend);
            this.panel2.Controls.Add(this.btDelete);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 28);
            this.panel2.TabIndex = 3;
            // 
            // btMac
            // 
            this.btMac.Location = new System.Drawing.Point(307, 1);
            this.btMac.Name = "btMac";
            this.btMac.Size = new System.Drawing.Size(75, 24);
            this.btMac.TabIndex = 6;
            this.btMac.Text = "获取Mac";
            this.btMac.UseVisualStyleBackColor = true;
            this.btMac.Click += new System.EventHandler(this.btMac_Click);
            // 
            // btAllsend
            // 
            this.btAllsend.Location = new System.Drawing.Point(231, 1);
            this.btAllsend.Name = "btAllsend";
            this.btAllsend.Size = new System.Drawing.Size(75, 24);
            this.btAllsend.TabIndex = 5;
            this.btAllsend.Text = "一键唤醒";
            this.btAllsend.UseVisualStyleBackColor = true;
            this.btAllsend.Click += new System.EventHandler(this.btAllsend_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(155, 1);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 24);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "删除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(3, 1);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 24);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "添加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAC地址：";
            // 
            // dgWOL
            // 
            this.dgWOL.AllowUserToAddRows = false;
            this.dgWOL.AllowUserToDeleteRows = false;
            this.dgWOL.AllowUserToResizeColumns = false;
            this.dgWOL.AllowUserToResizeRows = false;
            this.dgWOL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgWOL.BackgroundColor = System.Drawing.Color.White;
            this.dgWOL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgWOL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgWOL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWOL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsAutoSend,
            this.CMac,
            this.CMDName,
            this.CMDIp,
            this.btnSend});
            this.dgWOL.ContextMenuStrip = this.contextMenuStrip1;
            this.dgWOL.Location = new System.Drawing.Point(1, 90);
            this.dgWOL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgWOL.MultiSelect = false;
            this.dgWOL.Name = "dgWOL";
            this.dgWOL.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgWOL.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgWOL.RowHeadersVisible = false;
            this.dgWOL.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgWOL.RowTemplate.Height = 23;
            this.dgWOL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgWOL.Size = new System.Drawing.Size(538, 217);
            this.dgWOL.TabIndex = 1;
            this.dgWOL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgWOL_CellContentClick);
            this.dgWOL.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgWOL_CellDoubleClick);
            this.dgWOL.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgWOL_RowsAdded);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_add,
            this.MS_eidt,
            this.MS_delete,
            this.MS_wake,
            this.MS_getMac,
            this.MS_select});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 136);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // bt_Eidt
            // 
            this.bt_Eidt.Location = new System.Drawing.Point(79, 1);
            this.bt_Eidt.Name = "bt_Eidt";
            this.bt_Eidt.Size = new System.Drawing.Size(75, 24);
            this.bt_Eidt.TabIndex = 7;
            this.bt_Eidt.Text = "编辑";
            this.bt_Eidt.UseVisualStyleBackColor = true;
            this.bt_Eidt.Click += new System.EventHandler(this.bt_Eidt_Click);
            // 
            // MS_add
            // 
            this.MS_add.Name = "MS_add";
            this.MS_add.Size = new System.Drawing.Size(129, 22);
            this.MS_add.Text = "添加";
            this.MS_add.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // MS_eidt
            // 
            this.MS_eidt.Name = "MS_eidt";
            this.MS_eidt.Size = new System.Drawing.Size(129, 22);
            this.MS_eidt.Text = "编辑";
            this.MS_eidt.Click += new System.EventHandler(this.bt_Eidt_Click);
            // 
            // MS_delete
            // 
            this.MS_delete.Name = "MS_delete";
            this.MS_delete.Size = new System.Drawing.Size(129, 22);
            this.MS_delete.Text = "删除";
            this.MS_delete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // MS_wake
            // 
            this.MS_wake.Name = "MS_wake";
            this.MS_wake.Size = new System.Drawing.Size(129, 22);
            this.MS_wake.Text = "一键唤醒";
            this.MS_wake.Visible = false;
            this.MS_wake.Click += new System.EventHandler(this.btAllsend_Click);
            // 
            // MS_getMac
            // 
            this.MS_getMac.Name = "MS_getMac";
            this.MS_getMac.Size = new System.Drawing.Size(129, 22);
            this.MS_getMac.Text = "获取Mac";
            this.MS_getMac.Visible = false;
            this.MS_getMac.Click += new System.EventHandler(this.btMac_Click);
            // 
            // MS_select
            // 
            this.MS_select.Name = "MS_select";
            this.MS_select.Size = new System.Drawing.Size(129, 22);
            this.MS_select.Text = "全选/取消";
            this.MS_select.Click += new System.EventHandler(this.MS_select_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(421, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "提示：右键唤醒操作";
            // 
            // IsAutoSend
            // 
            this.IsAutoSend.FalseValue = "";
            this.IsAutoSend.HeaderText = "参与唤醒";
            this.IsAutoSend.Name = "IsAutoSend";
            this.IsAutoSend.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsAutoSend.TrueValue = "";
            this.IsAutoSend.Width = 85;
            // 
            // CMac
            // 
            this.CMac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CMac.DataPropertyName = "MAC";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CMac.DefaultCellStyle = dataGridViewCellStyle2;
            this.CMac.HeaderText = "MAC地址";
            this.CMac.Name = "CMac";
            this.CMac.ReadOnly = true;
            this.CMac.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CMac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CMDName
            // 
            this.CMDName.DataPropertyName = "NAME";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CMDName.DefaultCellStyle = dataGridViewCellStyle3;
            this.CMDName.HeaderText = "机器名称";
            this.CMDName.Name = "CMDName";
            this.CMDName.ReadOnly = true;
            this.CMDName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CMDIp
            // 
            this.CMDIp.DataPropertyName = "IP";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CMDIp.DefaultCellStyle = dataGridViewCellStyle4;
            this.CMDIp.HeaderText = "IP";
            this.CMDIp.Name = "CMDIp";
            this.CMDIp.ReadOnly = true;
            this.CMDIp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CMDIp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CMDIp.Width = 140;
            // 
            // btnSend
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.DefaultCellStyle = dataGridViewCellStyle5;
            this.btnSend.HeaderText = "唤醒";
            this.btnSend.Name = "btnSend";
            this.btnSend.ReadOnly = true;
            this.btnSend.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnSend.Text = "唤醒";
            this.btnSend.Width = 80;
            // 
            // WOLPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.dgWOL);
            this.Controls.Add(this.panel1);
            this.Name = "WOLPanel";
            this.Size = new System.Drawing.Size(540, 309);
            this.Load += new System.EventHandler(this.WOLPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWOL)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgWOL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btMac;
        private System.Windows.Forms.Button btAllsend;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private IpBoxControl.MACTextBox MacTextBox;
        private CCWin.SkinControl.SkinButton btWake;
        private System.Windows.Forms.Button bt_Eidt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_add;
        private System.Windows.Forms.ToolStripMenuItem MS_eidt;
        private System.Windows.Forms.ToolStripMenuItem MS_delete;
        private System.Windows.Forms.ToolStripMenuItem MS_wake;
        private System.Windows.Forms.ToolStripMenuItem MS_getMac;
        private System.Windows.Forms.ToolStripMenuItem MS_select;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAutoSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMac;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMDName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMDIp;
        private System.Windows.Forms.DataGridViewButtonColumn btnSend;
    }
}