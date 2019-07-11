using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LeafSoft
{
    public partial class frmAWOL : Form
    {
        public Model.WOL NewWOL = null;
        public frmAWOL()
        {
            InitializeComponent();
        }
        public frmAWOL(Model.WOL wol)
        {
            InitializeComponent();
            TextMac.Text = wol.MAC;
            TextName.Text = wol.NAME;
            TextIp.Text = wol.IP;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^([A-Fa-f0-9][A-Fa-f0-9]:[A-Fa-f0-9][A-Fa-f0-9]:[A-Fa-f0-9][A-Fa-f0-9]:[A-Fa-f0-9][A-Fa-f0-9]:[A-Fa-f0-9][A-Fa-f0-9]:[A-Fa-f0-9][A-Fa-f0-9])$");
            //NewWOL = new Model.WOL();
            string mac = TextMac.Text;
            if (!r.IsMatch(mac))
            {
                MessageBox.Show("输入的 MAC 地址无效!", "提示");
                return;
            }
            string name = TextName.Text;
            string ip = TextIp.Text;
            Regex regex = new Regex("^[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}$");
            if(!regex.IsMatch(ip) || (ip == "0.0.0.0"))
            {
                MessageBox.Show("输入的 IP 地址无效!", "提示");
                TextIp.Text = "";
                return;
            }
            NewWOL = new Model.WOL(mac,name,ip);
            if (NewWOL != null)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
