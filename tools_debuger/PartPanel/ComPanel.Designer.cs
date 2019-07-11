namespace LeafSoft.PartPanel
{
    partial class ComPanel
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_FontSet = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ClearCMD = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnSuper = new System.Windows.Forms.Button();
            this.DataSender = new LeafSoft.Units.DataSend();
            this.Configer = new LeafSoft.Units.NetRs232();
            this.txtCmd = new LeafSoft.LeafControl.CMDTextBox();
            this.DataReceiver = new LeafSoft.Units.DataReceive();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_FontSet,
            this.MS_ClearCMD});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 48);
            // 
            // MS_FontSet
            // 
            this.MS_FontSet.Name = "MS_FontSet";
            this.MS_FontSet.Size = new System.Drawing.Size(99, 22);
            this.MS_FontSet.Text = "字体调整";
            this.MS_FontSet.Click += new System.EventHandler(this.MS_FontSet_Click);
            // 
            // MS_ClearCMD
            // 
            this.MS_ClearCMD.Name = "MS_ClearCMD";
            this.MS_ClearCMD.Size = new System.Drawing.Size(99, 22);
            this.MS_ClearCMD.Text = "清空";
            this.MS_ClearCMD.Click += new System.EventHandler(this.MS_ClearCMD_Click);
            // 
            // btnSuper
            // 
            this.btnSuper.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSuper.Location = new System.Drawing.Point(16, 216);
            this.btnSuper.Name = "btnSuper";
            this.btnSuper.Size = new System.Drawing.Size(139, 30);
            this.btnSuper.TabIndex = 13;
            this.btnSuper.Text = "启用超级终端";
            this.btnSuper.UseVisualStyleBackColor = true;
            this.btnSuper.Click += new System.EventHandler(this.btnSuper_Click);
            // 
            // DataSender
            // 
            this.DataSender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataSender.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataSender.Location = new System.Drawing.Point(180, 0);
            this.DataSender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataSender.Name = "DataSender";
            this.DataSender.Size = new System.Drawing.Size(617, 250);
            this.DataSender.TabIndex = 12;
            this.DataSender.EventDataSend += new LeafSoft.Lib.LeafEvent.DataSendHandler(this.DataSender_EventDataSend);
            // 
            // Configer
            // 
            this.Configer.BackColor = System.Drawing.Color.White;
            this.Configer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Configer.Location = new System.Drawing.Point(0, 1);
            this.Configer.Name = "Configer";
            this.Configer.Size = new System.Drawing.Size(174, 210);
            this.Configer.TabIndex = 11;
            this.Configer.DataReceived += new LeafSoft.Lib.LeafEvent.DataReceivedHandler(this.Configer_DataReceived);
            // 
            // txtCmd
            // 
            this.txtCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCmd.BackColor = System.Drawing.Color.Black;
            this.txtCmd.ContextMenuStrip = this.contextMenuStrip1;
            this.txtCmd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCmd.ForeColor = System.Drawing.Color.White;
            this.txtCmd.Location = new System.Drawing.Point(0, 253);
            this.txtCmd.Multiline = true;
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCmd.Size = new System.Drawing.Size(800, 247);
            this.txtCmd.TabIndex = 15;
            this.txtCmd.Visible = false;
            this.txtCmd.DataSend += new LeafSoft.Lib.LeafEvent.DataSendHandler(this.txtCmd_DataSend);
            // 
            // DataReceiver
            // 
            this.DataReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataReceiver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataReceiver.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataReceiver.Location = new System.Drawing.Point(0, 253);
            this.DataReceiver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataReceiver.Name = "DataReceiver";
            this.DataReceiver.Size = new System.Drawing.Size(800, 247);
            this.DataReceiver.TabIndex = 14;
            // 
            // ComPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCmd);
            this.Controls.Add(this.DataReceiver);
            this.Controls.Add(this.btnSuper);
            this.Controls.Add(this.DataSender);
            this.Controls.Add(this.Configer);
            this.Name = "ComPanel";
            this.Size = new System.Drawing.Size(800, 500);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_ClearCMD;
        private System.Windows.Forms.ToolStripMenuItem MS_FontSet;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnSuper;
        public Units.DataSend DataSender;
        public Units.NetRs232 Configer;
        private LeafControl.CMDTextBox txtCmd;
        private Units.DataReceive DataReceiver;
    }
}
