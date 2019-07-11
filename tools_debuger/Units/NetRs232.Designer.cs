namespace LeafSoft.Units
{
    partial class NetRs232
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.drpBaudRate = new System.Windows.Forms.ComboBox();
            this.drpParity = new System.Windows.Forms.ComboBox();
            this.drpDataBits = new System.Windows.Forms.ComboBox();
            this.drpStopBits = new System.Windows.Forms.ComboBox();
            this.btnCom = new EASkins.Controls.MaterialRaisedButton();
            this.drpComList = new System.Windows.Forms.ComboBox();
            this.picComStatus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picComStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "串口";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "波特率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(17, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "校验位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(17, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "数据位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(17, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "停止位";
            // 
            // drpBaudRate
            // 
            this.drpBaudRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.drpBaudRate.DropDownHeight = 100;
            this.drpBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpBaudRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpBaudRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drpBaudRate.FormattingEnabled = true;
            this.drpBaudRate.IntegralHeight = false;
            this.drpBaudRate.ItemHeight = 17;
            this.drpBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.drpBaudRate.Location = new System.Drawing.Point(64, 38);
            this.drpBaudRate.Name = "drpBaudRate";
            this.drpBaudRate.Size = new System.Drawing.Size(89, 25);
            this.drpBaudRate.TabIndex = 37;
            // 
            // drpParity
            // 
            this.drpParity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.drpParity.DropDownHeight = 100;
            this.drpParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpParity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.drpParity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drpParity.FormattingEnabled = true;
            this.drpParity.IntegralHeight = false;
            this.drpParity.ItemHeight = 17;
            this.drpParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.drpParity.Location = new System.Drawing.Point(64, 70);
            this.drpParity.Name = "drpParity";
            this.drpParity.Size = new System.Drawing.Size(89, 25);
            this.drpParity.TabIndex = 38;
            // 
            // drpDataBits
            // 
            this.drpDataBits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.drpDataBits.DropDownHeight = 100;
            this.drpDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpDataBits.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.drpDataBits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drpDataBits.FormattingEnabled = true;
            this.drpDataBits.IntegralHeight = false;
            this.drpDataBits.ItemHeight = 17;
            this.drpDataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.drpDataBits.Location = new System.Drawing.Point(64, 102);
            this.drpDataBits.Name = "drpDataBits";
            this.drpDataBits.Size = new System.Drawing.Size(89, 25);
            this.drpDataBits.TabIndex = 39;
            // 
            // drpStopBits
            // 
            this.drpStopBits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.drpStopBits.DropDownHeight = 100;
            this.drpStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpStopBits.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpStopBits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drpStopBits.FormattingEnabled = true;
            this.drpStopBits.IntegralHeight = false;
            this.drpStopBits.ItemHeight = 19;
            this.drpStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.drpStopBits.Location = new System.Drawing.Point(64, 134);
            this.drpStopBits.Name = "drpStopBits";
            this.drpStopBits.Size = new System.Drawing.Size(89, 27);
            this.drpStopBits.TabIndex = 40;
            // 
            // btnCom
            // 
            this.btnCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCom.AutoSize = true;
            this.btnCom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCom.BackColor = System.Drawing.Color.White;
            this.btnCom.Depth = 0;
            this.btnCom.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCom.Icon = null;
            this.btnCom.Location = new System.Drawing.Point(64, 186);
            this.btnCom.MouseState = EASkins.MouseState.HOVER;
            this.btnCom.Name = "btnCom";
            this.btnCom.Primary = true;
            this.btnCom.Size = new System.Drawing.Size(81, 36);
            this.btnCom.TabIndex = 41;
            this.btnCom.Text = "打开串口";
            this.btnCom.UseVisualStyleBackColor = false;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // drpComList
            // 
            this.drpComList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.drpComList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpComList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.drpComList.FormattingEnabled = true;
            this.drpComList.ItemHeight = 17;
            this.drpComList.Items.AddRange(new object[] {
            "COM1"});
            this.drpComList.Location = new System.Drawing.Point(64, 8);
            this.drpComList.Name = "drpComList";
            this.drpComList.Size = new System.Drawing.Size(89, 25);
            this.drpComList.TabIndex = 42;
            // 
            // picComStatus
            // 
            this.picComStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picComStatus.BackgroundImage = global::LeafSoft.Properties.Resources.redlight;
            this.picComStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picComStatus.Location = new System.Drawing.Point(20, 186);
            this.picComStatus.Name = "picComStatus";
            this.picComStatus.Size = new System.Drawing.Size(39, 37);
            this.picComStatus.TabIndex = 35;
            this.picComStatus.TabStop = false;
            // 
            // NetRs232
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.drpComList);
            this.Controls.Add(this.btnCom);
            this.Controls.Add(this.drpStopBits);
            this.Controls.Add(this.drpDataBits);
            this.Controls.Add(this.drpParity);
            this.Controls.Add(this.drpBaudRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picComStatus);
            this.Name = "NetRs232";
            this.Size = new System.Drawing.Size(172, 229);
            ((System.ComponentModel.ISupportInitialize)(this.picComStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picComStatus;
        private EASkins.Controls.MaterialRaisedButton btnCom;
        private System.Windows.Forms.ComboBox drpBaudRate;
        private System.Windows.Forms.ComboBox drpParity;
        private System.Windows.Forms.ComboBox drpDataBits;
        private System.Windows.Forms.ComboBox drpStopBits;
        private System.Windows.Forms.ComboBox drpComList;
    }
}
