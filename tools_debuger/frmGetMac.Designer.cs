namespace LeafSoft
{
    partial class frmGetMac
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
            this.TextName = new EASkins.Ami_TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ami_Label2 = new EASkins.Ami_Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TextMac = new IpBoxControl.MACTextBox();
            this.TextIp = new IpBoxControl.IpTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextName
            // 
            this.TextName.BackColor = System.Drawing.Color.Transparent;
            this.TextName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TextName.ForeColor = System.Drawing.Color.Silver;
            this.TextName.Location = new System.Drawing.Point(108, 64);
            this.TextName.MaxLength = 32767;
            this.TextName.Multiline = false;
            this.TextName.Name = "TextName";
            this.TextName.ReadOnly = false;
            this.TextName.Size = new System.Drawing.Size(149, 28);
            this.TextName.TabIndex = 21;
            this.TextName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextName.UseSystemPasswordChar = false;
            // 
            // btGet
            // 
            this.btGet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btGet.Location = new System.Drawing.Point(23, 163);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(83, 28);
            this.btGet.TabIndex = 19;
            this.btGet.Text = "获取ALL";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Location = new System.Drawing.Point(198, 163);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(74, 28);
            this.btAdd.TabIndex = 18;
            this.btAdd.Text = "加入列表";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(27, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "目标IP地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(50, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "名   称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "MAC地址：";
            // 
            // ami_Label2
            // 
            this.ami_Label2.AutoSize = true;
            this.ami_Label2.BackColor = System.Drawing.Color.Transparent;
            this.ami_Label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ami_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ami_Label2.Location = new System.Drawing.Point(108, 40);
            this.ami_Label2.Name = "ami_Label2";
            this.ami_Label2.Size = new System.Drawing.Size(124, 20);
            this.ami_Label2.TabIndex = 23;
            this.ami_Label2.Text = "例：xxx . xxx . xxx";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(112, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 28);
            this.button1.TabIndex = 26;
            this.button1.Text = "获取Mac";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextMac
            // 
            this.TextMac.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextMac.Location = new System.Drawing.Point(108, 116);
            this.TextMac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextMac.Name = "TextMac";
            this.TextMac.Size = new System.Drawing.Size(170, 26);
            this.TextMac.TabIndex = 25;
            // 
            // TextIp
            // 
            this.TextIp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextIp.Location = new System.Drawing.Point(108, 14);
            this.TextIp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextIp.Name = "TextIp";
            this.TextIp.Size = new System.Drawing.Size(140, 24);
            this.TextIp.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(112, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 28);
            this.button2.TabIndex = 27;
            this.button2.Text = "获取IP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmGetMac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(284, 218);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextMac);
            this.Controls.Add(this.TextIp);
            this.Controls.Add(this.ami_Label2);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGetMac";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "获取MAC地址";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EASkins.Ami_TextBox TextName;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private EASkins.Ami_Label ami_Label2;
        private IpBoxControl.IpTextBox TextIp;
        private IpBoxControl.MACTextBox TextMac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}