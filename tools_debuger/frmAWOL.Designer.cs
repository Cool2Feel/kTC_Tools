namespace LeafSoft
{
    partial class frmAWOL
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TextName = new EASkins.Ami_TextBox();
            this.ami_Label1 = new EASkins.Ami_Label();
            this.ami_Label2 = new EASkins.Ami_Label();
            this.TextMac = new IpBoxControl.MACTextBox();
            this.TextIp = new IpBoxControl.IpTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAC地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(65, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "名   称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(66, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP地址：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(188, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(59, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TextName
            // 
            this.TextName.BackColor = System.Drawing.Color.Transparent;
            this.TextName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TextName.ForeColor = System.Drawing.Color.DimGray;
            this.TextName.Location = new System.Drawing.Point(124, 73);
            this.TextName.MaxLength = 32767;
            this.TextName.Multiline = false;
            this.TextName.Name = "TextName";
            this.TextName.ReadOnly = false;
            this.TextName.Size = new System.Drawing.Size(135, 28);
            this.TextName.TabIndex = 11;
            this.TextName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextName.UseSystemPasswordChar = false;
            // 
            // ami_Label1
            // 
            this.ami_Label1.AutoSize = true;
            this.ami_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ami_Label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ami_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ami_Label1.Location = new System.Drawing.Point(113, 49);
            this.ami_Label1.Name = "ami_Label1";
            this.ami_Label1.Size = new System.Drawing.Size(178, 20);
            this.ami_Label1.TabIndex = 13;
            this.ami_Label1.Text = "例：xx : xx : xx : xx : xx : xx";
            // 
            // ami_Label2
            // 
            this.ami_Label2.AutoSize = true;
            this.ami_Label2.BackColor = System.Drawing.Color.Transparent;
            this.ami_Label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ami_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ami_Label2.Location = new System.Drawing.Point(120, 153);
            this.ami_Label2.Name = "ami_Label2";
            this.ami_Label2.Size = new System.Drawing.Size(124, 20);
            this.ami_Label2.TabIndex = 14;
            this.ami_Label2.Text = "例：xxx . xxx . xxx";
            // 
            // TextMac
            // 
            this.TextMac.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextMac.Location = new System.Drawing.Point(124, 20);
            this.TextMac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextMac.Name = "TextMac";
            this.TextMac.Size = new System.Drawing.Size(166, 26);
            this.TextMac.TabIndex = 27;
            // 
            // TextIp
            // 
            this.TextIp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextIp.Location = new System.Drawing.Point(124, 124);
            this.TextIp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextIp.Name = "TextIp";
            this.TextIp.Size = new System.Drawing.Size(140, 24);
            this.TextIp.TabIndex = 28;
            // 
            // frmAWOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 229);
            this.Controls.Add(this.TextIp);
            this.Controls.Add(this.TextMac);
            this.Controls.Add(this.ami_Label2);
            this.Controls.Add(this.ami_Label1);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAWOL";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "添加唤醒信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private EASkins.Ami_TextBox TextName;
        private EASkins.Ami_Label ami_Label1;
        private EASkins.Ami_Label ami_Label2;
        private IpBoxControl.MACTextBox TextMac;
        private IpBoxControl.IpTextBox TextIp;
    }
}