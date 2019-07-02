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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btMac = new System.Windows.Forms.Button();
            this.btAllsend = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgWOL = new System.Windows.Forms.DataGridView();
            this.IsAutoSend = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CMac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMDName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMDIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSend = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MacTextBox = new IpBoxControl.MACTextBox();
            this.btWake = new CCWin.SkinControl.SkinButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWOL)).BeginInit();
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
            // panel2
            // 
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
            this.btMac.Location = new System.Drawing.Point(228, 1);
            this.btMac.Name = "btMac";
            this.btMac.Size = new System.Drawing.Size(75, 24);
            this.btMac.TabIndex = 6;
            this.btMac.Text = "获取Mac";
            this.btMac.UseVisualStyleBackColor = true;
            this.btMac.Click += new System.EventHandler(this.btMac_Click);
            // 
            // btAllsend
            // 
            this.btAllsend.Location = new System.Drawing.Point(153, 1);
            this.btAllsend.Name = "btAllsend";
            this.btAllsend.Size = new System.Drawing.Size(75, 24);
            this.btAllsend.TabIndex = 5;
            this.btAllsend.Text = "一键唤醒";
            this.btAllsend.UseVisualStyleBackColor = true;
            this.btAllsend.Click += new System.EventHandler(this.btAllsend_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(78, 1);
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
            this.dgWOL.AllowUserToResizeRows = false;
            this.dgWOL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgWOL.BackgroundColor = System.Drawing.Color.White;
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
            this.dgWOL.Location = new System.Drawing.Point(1, 90);
            this.dgWOL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgWOL.MultiSelect = false;
            this.dgWOL.Name = "dgWOL";
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
            // IsAutoSend
            // 
            this.IsAutoSend.HeaderText = "参与唤醒";
            this.IsAutoSend.Name = "IsAutoSend";
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
            this.btnSend.Text = "唤醒";
            this.btnSend.Width = 80;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgWOL)).EndInit();
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAutoSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMac;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMDName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMDIp;
        private System.Windows.Forms.DataGridViewButtonColumn btnSend;
        private IpBoxControl.MACTextBox MacTextBox;
        private CCWin.SkinControl.SkinButton btWake;
    }
}