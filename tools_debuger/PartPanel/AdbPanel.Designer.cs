namespace LeafSoft.PartPanel
{
    partial class AdbPanel
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtListInfo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearCmd = new System.Windows.Forms.Button();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.btnStopADB = new System.Windows.Forms.Button();
            this.cboAllADBCmd = new System.Windows.Forms.ComboBox();
            this.txtCustomCmd = new System.Windows.Forms.TextBox();
            this.btnGetDevice = new System.Windows.Forms.Button();
            this.btnStartADB = new System.Windows.Forms.Button();
            this.btnADBVersion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSendCmd = new System.Windows.Forms.Button();
            this.bt_connect = new System.Windows.Forms.Button();
            this.txtCustomIP = new IpBoxControl.IpTextBox();
            this.txtCustomPath = new System.Windows.Forms.TextBox();
            this.bt_pull = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtListInfo
            // 
            this.txtListInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtListInfo.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtListInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtListInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtListInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtListInfo.Location = new System.Drawing.Point(0, 0);
            this.txtListInfo.Multiline = true;
            this.txtListInfo.Name = "txtListInfo";
            this.txtListInfo.ReadOnly = true;
            this.txtListInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtListInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtListInfo.Size = new System.Drawing.Size(472, 385);
            this.txtListInfo.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bt_pull);
            this.panel1.Controls.Add(this.txtCustomPath);
            this.panel1.Controls.Add(this.txtCustomIP);
            this.panel1.Controls.Add(this.bt_connect);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnClearCmd);
            this.panel1.Controls.Add(this.txtOS);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDeviceName);
            this.panel1.Controls.Add(this.cboDevice);
            this.panel1.Controls.Add(this.btnStopADB);
            this.panel1.Controls.Add(this.cboAllADBCmd);
            this.panel1.Controls.Add(this.btnSendCmd);
            this.panel1.Controls.Add(this.txtCustomCmd);
            this.panel1.Controls.Add(this.btnGetDevice);
            this.panel1.Controls.Add(this.btnStartADB);
            this.panel1.Controls.Add(this.btnADBVersion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(472, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 385);
            this.panel1.TabIndex = 12;
            // 
            // btnClearCmd
            // 
            this.btnClearCmd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearCmd.Location = new System.Drawing.Point(66, 353);
            this.btnClearCmd.Name = "btnClearCmd";
            this.btnClearCmd.Size = new System.Drawing.Size(131, 24);
            this.btnClearCmd.TabIndex = 44;
            this.btnClearCmd.Text = "清空列表信息";
            this.btnClearCmd.UseVisualStyleBackColor = true;
            this.btnClearCmd.Visible = false;
            this.btnClearCmd.Click += new System.EventHandler(this.btnClearCmd_Click);
            // 
            // txtOS
            // 
            this.txtOS.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOS.Location = new System.Drawing.Point(66, 343);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(129, 23);
            this.txtOS.TabIndex = 43;
            this.txtOS.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(6, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "操作系统:";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "设备名称:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "设备序号:";
            this.label1.Visible = false;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDeviceName.Location = new System.Drawing.Point(66, 346);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(129, 23);
            this.txtDeviceName.TabIndex = 39;
            this.txtDeviceName.Visible = false;
            // 
            // cboDevice
            // 
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(66, 343);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(129, 25);
            this.cboDevice.TabIndex = 38;
            this.cboDevice.Visible = false;
            this.cboDevice.SelectedIndexChanged += new System.EventHandler(this.cboDevice_SelectedIndexChanged);
            // 
            // btnStopADB
            // 
            this.btnStopADB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStopADB.Location = new System.Drawing.Point(13, 245);
            this.btnStopADB.Name = "btnStopADB";
            this.btnStopADB.Size = new System.Drawing.Size(92, 26);
            this.btnStopADB.TabIndex = 37;
            this.btnStopADB.Text = "停止ADB服务";
            this.btnStopADB.UseVisualStyleBackColor = true;
            this.btnStopADB.Click += new System.EventHandler(this.btnStopADB_Click);
            // 
            // cboAllADBCmd
            // 
            this.cboAllADBCmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAllADBCmd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboAllADBCmd.FormattingEnabled = true;
            this.cboAllADBCmd.Location = new System.Drawing.Point(12, 8);
            this.cboAllADBCmd.Name = "cboAllADBCmd";
            this.cboAllADBCmd.Size = new System.Drawing.Size(191, 25);
            this.cboAllADBCmd.TabIndex = 36;
            this.cboAllADBCmd.SelectedIndexChanged += new System.EventHandler(this.cboAllADBCmd_SelectedIndexChanged);
            // 
            // txtCustomCmd
            // 
            this.txtCustomCmd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustomCmd.Location = new System.Drawing.Point(5, 59);
            this.txtCustomCmd.Multiline = true;
            this.txtCustomCmd.Name = "txtCustomCmd";
            this.txtCustomCmd.Size = new System.Drawing.Size(142, 59);
            this.txtCustomCmd.TabIndex = 11;
            this.txtCustomCmd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustomCmd_KeyUp);
            // 
            // btnGetDevice
            // 
            this.btnGetDevice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetDevice.Location = new System.Drawing.Point(111, 279);
            this.btnGetDevice.Name = "btnGetDevice";
            this.btnGetDevice.Size = new System.Drawing.Size(92, 26);
            this.btnGetDevice.TabIndex = 33;
            this.btnGetDevice.Text = "获取连接设备";
            this.btnGetDevice.UseVisualStyleBackColor = true;
            this.btnGetDevice.Click += new System.EventHandler(this.btnGetDevice_Click);
            // 
            // btnStartADB
            // 
            this.btnStartADB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartADB.Location = new System.Drawing.Point(111, 245);
            this.btnStartADB.Name = "btnStartADB";
            this.btnStartADB.Size = new System.Drawing.Size(92, 26);
            this.btnStartADB.TabIndex = 32;
            this.btnStartADB.Text = "启动ADB服务";
            this.btnStartADB.UseVisualStyleBackColor = true;
            this.btnStartADB.Click += new System.EventHandler(this.btnStartADB_Click);
            // 
            // btnADBVersion
            // 
            this.btnADBVersion.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnADBVersion.Location = new System.Drawing.Point(13, 279);
            this.btnADBVersion.Name = "btnADBVersion";
            this.btnADBVersion.Size = new System.Drawing.Size(92, 26);
            this.btnADBVersion.TabIndex = 31;
            this.btnADBVersion.Text = "ADB版本";
            this.btnADBVersion.UseVisualStyleBackColor = true;
            this.btnADBVersion.Click += new System.EventHandler(this.btnADBVersion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "adb命令 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Connect IP :";
            // 
            // btnSendCmd
            // 
            this.btnSendCmd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSendCmd.Location = new System.Drawing.Point(149, 69);
            this.btnSendCmd.Name = "btnSendCmd";
            this.btnSendCmd.Size = new System.Drawing.Size(66, 38);
            this.btnSendCmd.TabIndex = 35;
            this.btnSendCmd.Text = "发送指令";
            this.btnSendCmd.UseVisualStyleBackColor = true;
            this.btnSendCmd.Click += new System.EventHandler(this.btnSendCmd_Click);
            // 
            // bt_connect
            // 
            this.bt_connect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_connect.Location = new System.Drawing.Point(149, 135);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(66, 28);
            this.bt_connect.TabIndex = 48;
            this.bt_connect.Text = "connect";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // txtCustomIP
            // 
            this.txtCustomIP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustomIP.Location = new System.Drawing.Point(5, 137);
            this.txtCustomIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomIP.Name = "txtCustomIP";
            this.txtCustomIP.Size = new System.Drawing.Size(142, 24);
            this.txtCustomIP.TabIndex = 49;
            // 
            // txtCustomPath
            // 
            this.txtCustomPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustomPath.Location = new System.Drawing.Point(3, 185);
            this.txtCustomPath.Name = "txtCustomPath";
            this.txtCustomPath.Size = new System.Drawing.Size(144, 23);
            this.txtCustomPath.TabIndex = 50;
            this.txtCustomPath.Text = "/data/log/debug.log*";
            // 
            // bt_pull
            // 
            this.bt_pull.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_pull.Location = new System.Drawing.Point(149, 182);
            this.bt_pull.Name = "bt_pull";
            this.bt_pull.Size = new System.Drawing.Size(66, 28);
            this.bt_pull.TabIndex = 51;
            this.bt_pull.Text = "pull log";
            this.bt_pull.UseVisualStyleBackColor = true;
            this.bt_pull.Click += new System.EventHandler(this.bt_pull_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "pull 路径 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Location = new System.Drawing.Point(100, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "pull到本地: E:\\Log\\ ";
            // 
            // AdbPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtListInfo);
            this.Name = "AdbPanel";
            this.Size = new System.Drawing.Size(690, 385);
            this.Load += new System.EventHandler(this.AdbPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtListInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStopADB;
        private System.Windows.Forms.ComboBox cboAllADBCmd;
        private System.Windows.Forms.TextBox txtCustomCmd;
        private System.Windows.Forms.Button btnGetDevice;
        private System.Windows.Forms.Button btnStartADB;
        private System.Windows.Forms.Button btnADBVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Button btnClearCmd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSendCmd;
        private IpBoxControl.IpTextBox txtCustomIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_pull;
        private System.Windows.Forms.TextBox txtCustomPath;
        private System.Windows.Forms.Label label7;
    }
}
