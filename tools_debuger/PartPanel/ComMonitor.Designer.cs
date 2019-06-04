namespace LeafSoft.PartPanel
{
    partial class ComMonitor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comPort = new System.Windows.Forms.Label();
            this.comSelect = new System.Windows.Forms.ComboBox();
            this.comStart = new System.Windows.Forms.Button();
            this.comPause = new System.Windows.Forms.Button();
            this.redtData = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTip = new System.Windows.Forms.ToolStripStatusLabel();
            this.appHint = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.comPause);
            this.panel1.Controls.Add(this.comStart);
            this.panel1.Controls.Add(this.comSelect);
            this.panel1.Controls.Add(this.comPort);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 54);
            this.panel1.TabIndex = 0;
            // 
            // comPort
            // 
            this.comPort.AutoSize = true;
            this.comPort.Location = new System.Drawing.Point(18, 20);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(41, 12);
            this.comPort.TabIndex = 0;
            this.comPort.Text = "串口：";
            // 
            // comSelect
            // 
            this.comSelect.FormattingEnabled = true;
            this.comSelect.Location = new System.Drawing.Point(65, 17);
            this.comSelect.Name = "comSelect";
            this.comSelect.Size = new System.Drawing.Size(68, 20);
            this.comSelect.TabIndex = 1;
            // 
            // comStart
            // 
            this.comStart.Location = new System.Drawing.Point(175, 15);
            this.comStart.Name = "comStart";
            this.comStart.Size = new System.Drawing.Size(75, 23);
            this.comStart.TabIndex = 2;
            this.comStart.Text = "Start";
            this.comStart.UseVisualStyleBackColor = true;
            // 
            // comPause
            // 
            this.comPause.Location = new System.Drawing.Point(275, 15);
            this.comPause.Name = "comPause";
            this.comPause.Size = new System.Drawing.Size(75, 23);
            this.comPause.TabIndex = 3;
            this.comPause.Text = "Pause";
            this.comPause.UseVisualStyleBackColor = true;
            // 
            // redtData
            // 
            this.redtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redtData.Location = new System.Drawing.Point(4, 63);
            this.redtData.Name = "redtData";
            this.redtData.Size = new System.Drawing.Size(635, 230);
            this.redtData.TabIndex = 1;
            this.redtData.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTip,
            this.appHint,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 300);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(642, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTip
            // 
            this.lblTip.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblTip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(298, 17);
            this.lblTip.Spring = true;
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // appHint
            // 
            this.appHint.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.appHint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.appHint.Name = "appHint";
            this.appHint.Size = new System.Drawing.Size(298, 17);
            this.appHint.Spring = true;
            this.appHint.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // ComMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.redtData);
            this.Controls.Add(this.panel1);
            this.Name = "ComMonitor";
            this.Size = new System.Drawing.Size(642, 322);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button comPause;
        private System.Windows.Forms.Button comStart;
        private System.Windows.Forms.ComboBox comSelect;
        private System.Windows.Forms.Label comPort;
        private System.Windows.Forms.RichTextBox redtData;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTip;
        private System.Windows.Forms.ToolStripStatusLabel appHint;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
