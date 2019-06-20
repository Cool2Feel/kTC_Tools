using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace LeafSoft.PartPanel
{
    public partial class ComPanel : BasePanel
    {
        public ComPanel()
        {
            InitializeComponent();
        }

        private bool DataSender_EventDataSend(byte[] data)
        {
            return Configer.SendData(data);
        }

        private void Configer_DataReceived(object sender, byte[] data)
        {
            if (txtCmd.Visible == true)
            {
                if(data.Length>1)
                {
                    txtCmd.BeginInvoke(new MethodInvoker(delegate
                    {
                        txtCmd.AppendText(new UTF8Encoding().GetString(data).Replace("\r", "\r\n"));
                        txtCmd.SelectionStart = txtCmd.Text.Length;  
                    }));
                }
            }
            else
            {
                DataReceiver.AddData(data);
            }
        }

        public override void ClearSelf()
        {
            Configer.ClearSelf();
        }

        private void btnSuper_Click(object sender, EventArgs e)
        {
            txtCmd.Visible = !txtCmd.Visible;
            if(txtCmd.Visible)
            {
                btnSuper.Text = "关闭超级终端";
                btnSuper.ForeColor = Color.Red;
            }
            else
            {
                btnSuper.Text = "启用超级终端";
                btnSuper.ForeColor = Color.Black;
            }
            txtCmd.Focus();
        }

        private bool txtCmd_DataSend(byte[] cmd)
        {
           return Configer.SendData(cmd);
        }

        private void MS_ClearCMD_Click(object sender, EventArgs e)
        {
            txtCmd.Clear();
        }
    }
}
