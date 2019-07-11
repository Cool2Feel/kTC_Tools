namespace LeafSoft.Units
{
    partial class NetTCPServer
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
            this.btnListen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nmServerPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lstConn = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxServerIP = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmServerPort)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnListen.Location = new System.Drawing.Point(110, 35);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(55, 24);
            this.btnListen.TabIndex = 10;
            this.btnListen.Text = "监听";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "本地IP:";
            // 
            // nmServerPort
            // 
            this.nmServerPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmServerPort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nmServerPort.Location = new System.Drawing.Point(49, 36);
            this.nmServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nmServerPort.Name = "nmServerPort";
            this.nmServerPort.Size = new System.Drawing.Size(56, 23);
            this.nmServerPort.TabIndex = 7;
            this.nmServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmServerPort.Value = new decimal(new int[] {
            2756,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "端口:";
            // 
            // lstConn
            // 
            this.lstConn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstConn.ContextMenuStrip = this.contextMenuStrip1;
            this.lstConn.DisplayMember = "Name";
            this.lstConn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstConn.FormattingEnabled = true;
            this.lstConn.ItemHeight = 17;
            this.lstConn.Location = new System.Drawing.Point(0, 69);
            this.lstConn.Name = "lstConn";
            this.lstConn.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstConn.Size = new System.Drawing.Size(172, 157);
            this.lstConn.TabIndex = 11;
            this.toolTip1.SetToolTip(this.lstConn, "右键断开连接");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // MS_Delete
            // 
            this.MS_Delete.Name = "MS_Delete";
            this.MS_Delete.Size = new System.Drawing.Size(124, 22);
            this.MS_Delete.Text = "断开连接";
            this.MS_Delete.Click += new System.EventHandler(this.MS_Delete_Click);
            // 
            // cbxServerIP
            // 
            this.cbxServerIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cbxServerIP.DropDownHeight = 100;
            this.cbxServerIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxServerIP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxServerIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.cbxServerIP.FormattingEnabled = true;
            this.cbxServerIP.IntegralHeight = false;
            this.cbxServerIP.ItemHeight = 17;
            this.cbxServerIP.Items.AddRange(new object[] {
            "192.168.0.1"});
            this.cbxServerIP.Location = new System.Drawing.Point(50, 2);
            this.cbxServerIP.Name = "cbxServerIP";
            this.cbxServerIP.Size = new System.Drawing.Size(115, 25);
            this.cbxServerIP.TabIndex = 37;
            // 
            // NetTCPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.cbxServerIP);
            this.Controls.Add(this.lstConn);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmServerPort);
            this.Controls.Add(this.label1);
            this.Name = "NetTCPServer";
            this.Size = new System.Drawing.Size(174, 229);
            ((System.ComponentModel.ISupportInitialize)(this.nmServerPort)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmServerPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstConn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_Delete;
        private System.Windows.Forms.ComboBox cbxServerIP;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
