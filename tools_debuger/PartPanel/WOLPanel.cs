﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using LeafSoft.Lib;
using System.Threading;

namespace LeafSoft.PartPanel
{
    public partial class WOLPanel : UserControl
    {
        BindingList<Model.WOL> lstWOL = new BindingList<Model.WOL>();
        List<string> ipList = new List<string>();
        private IniFiles settingFile;//配置文件

        /// <summary>
        /// 是否在唤醒状态
        /// </summary>
        bool AutoSend = false;

        public WOLPanel()
        {
            InitializeComponent();
            dgWOL.AutoGenerateColumns = false;
            /*
            IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in ipHostEntry.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {//筛选IPV4
                    ipList.Add(ip.ToString());
                }
            }
            string ip1 = ipList[0];
            */
            //lstWOL.Add(new Model.WOL("00:51:62:48:51:02","dwl","192.168.3.69"));
            dgWOL.DataSource = lstWOL;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MacTextBox.Text))
            {
                //byte[] mac = MacToBytes(MacTextBox.Text);

                //SendWakeOnLanPacket(mac);
                WOL.AquilaWolLibrary.WakeUp(MacTextBox.Text);

                LogHelper.WriteLog("WOL Date: " + MacTextBox.Text);
                MessageBox.Show("已发送唤醒数据信息！", "提示");
            }
            else
                MessageBox.Show("请输入正确的MAC地址进行唤醒！","提示");
        }

        private static void SendWakeOnLanPacket(byte[] mac)
        {
            //
            // WOL 包通过 UDP 255.255.255.0:40000 发送。
            //
            UdpClient client = new UdpClient();
            client.Connect(IPAddress.Broadcast, 40000);

            //
            // WOL 包含了6个字节的属部和16倍6字节序列包含MAC地址.
            //
            byte[] packet = new byte[17 * 6];

            //
            // 尾部6倍的 0xFF.
            //
            for (int i = 0; i < 6; i++)
                packet[i] = 0xFF;

            //
            // 魔术包主体部分包含了16倍的MAC地址。
            //
            for (int i = 1; i <= 16; i++)
                for (int j = 0; j < 6; j++)
                    packet[i * 6 + j] = mac[j];

            //
            // 发送唤醒包。
            //
            client.Send(packet, packet.Length);
        }
        private static void SendWakeOnLanPacket(byte[] mac,string ip)
        {
            //
            // WOL 包通过 UDP 255.255.255.0:40000 发送。
            //
            UdpClient client = new UdpClient();
            client.Connect(IPAddress.Parse(ip), 40000);

            //
            // WOL 包含了6个字节的属部和16倍6字节序列包含MAC地址.
            //
            byte[] packet = new byte[17 * 6];

            //
            // 尾部6倍的 0xFF.
            //
            for (int i = 0; i < 6; i++)
                packet[i] = 0xFF;

            //
            // 魔术包主体部分包含了16倍的MAC地址。
            //
            for (int i = 1; i <= 16; i++)
                for (int j = 0; j < 6; j++)
                    packet[i * 6 + j] = mac[j];

            //
            // 发送唤醒包。
            //
            client.Send(packet, packet.Length);
        }
        
        //private GetMac GM;
        private void btMac_Click(object sender, EventArgs e)
        {
            //GM = new GetMac(ipList[0]);
            //lstWOL.Add(new Model.WOL(GM.MAC,GM.NAME,GM.IP));
            frmGetMac fMac = new frmGetMac();
            if (fMac.ShowDialog() == DialogResult.OK)
            {
                lstWOL.Add(fMac.NewWOL);
            }
        }

        private void dgWOL_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgWOL.Rows[e.RowIndex].Cells[4].Value = "唤醒";
        }

        private byte[] MacToBytes(string macString)
        {
            try
            {
                if (null != macString && macString.Split(':').Length == 6)
                {
                    string[] macStringArray = macString.Split(':');
                    byte[] macByteArray = new byte[6];
                    for (int i = 0; i < 6; i++)
                    {
                        macByteArray[i] = Convert.ToByte(macStringArray[i], 16);
                    }
                    return macByteArray;
                }
            }
            catch
            {
                MessageBox.Show("请检查您输入的MAC地址格式，例如：70:71:BC:22:AE:3A");
            }
            return null;
        }
        /// <summary>
        /// 唤醒点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgWOL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {//点击了唤醒按钮 
                string macString = dgWOL.Rows[e.RowIndex].Cells[1].Value.ToString();
                string ipString = dgWOL.Rows[e.RowIndex].Cells[3].Value.ToString();
                byte[] macByte = MacToBytes(macString);
                if (null != macByte)
                {
                    SendWakeOnLanPacket(macByte, ipString);
                    LogHelper.WriteLog("WOL Date: " + macString);
                    MessageBox.Show("已发送唤醒数据信息！", "提示");
                }
            }
        }

        private void dgWOL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string macString = dgWOL.Rows[e.RowIndex].Cells[1].Value.ToString();
                if(macString != "")
                {
                    MacTextBox.Text = macString;
                }
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgWOL.SelectedRows.Count > 0)
            {
                lstWOL.RemoveAt(dgWOL.SelectedRows[0].Index);
            }
        }

        private bool CheckSelectSend()
        {
            for (int i = 0; i < lstWOL.Count; i++)
            {
                object cbxValue = dgWOL.Rows[i].Cells[0].Value;
                if (cbxValue is bool && cbxValue.Equals(true))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 一键唤醒
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAllsend_Click(object sender, EventArgs e)
        {
            if (AutoSend == false)
            {
                btAllsend.Text = "停止唤醒";
                dgWOL.Enabled = false;
                AutoSend = true;
                if (CheckSelectSend())
                {
                    Thread ThTestL = new Thread(new ThreadStart(TWakeSend));
                    ThTestL.IsBackground = true;
                    ThTestL.Start();
                }
                else
                {
                    MessageBox.Show("没有发送的指令选项", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    StopWakeSend();
                }
            }
            else
            {
                StopWakeSend();
            }
        }

        private void TWakeSend()
        {
            try
            {
                while (AutoSend)
                {
                    for (int i = 0; i < lstWOL.Count; i++)
                    {
                        if (AutoSend)
                        {
                            this.Invoke(new MethodInvoker(delegate
                            {
                                object cbxValue = dgWOL.Rows[i].Cells[0].Value;
                                if (cbxValue is bool && cbxValue.Equals(true))
                                {
                                    string macString = dgWOL.Rows[i].Cells[1].Value.ToString();
                                    string ipString = dgWOL.Rows[i].Cells[3].Value.ToString();
                                    byte[] macByte = MacToBytes(macString);
                                    if (null != macByte)
                                    {
                                        SendWakeOnLanPacket(macByte, ipString);

                                        LogHelper.WriteLog("WOL Date: " + macString);
                                    }
                                }
                            }));
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            catch
            { }
        }

        /// <summary>
        /// 停止唤醒
        /// </summary>
        private void StopWakeSend()
        {
            AutoSend = false;
            btAllsend.Text = "一键唤醒";
            dgWOL.Enabled = true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmAWOL fCmd = new frmAWOL();
            if (fCmd.ShowDialog() == DialogResult.OK)
            {
                lstWOL.Add(fCmd.NewWOL);
            }
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            btDelete.Enabled = true;
            btAllsend.Enabled = true;
        }

        #region 加载和保存
        private void Load_Inifile()
        {
            try
            {
                //string s = settingFile.ReadString("SETTING", "COM", "COM1");
                int count = settingFile.ReadInteger("SETTING", "COUNT", 0);
                lstWOL.Clear();
                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        string data = settingFile.ReadString("DATA", "W" + i, "");
                        if (!data.Equals(""))
                        {
                            string[] str = data.Split(',');
                            //byte[] byteArray = Encoding.Default.GetBytes(str[1]);
                            Model.WOL cmd = new Model.WOL(str[0],str[1],str[2]);
                            lstWOL.Add(cmd);
                            //Console.Write(data);
                        }
                    }

                }
            }
            catch
            {

            }
        }

        private void Save_Inifile()
        {
            try
            {
                settingFile.WriteInteger("SETTING", "COUNT", lstWOL.Count);
                if (lstWOL.Count > 0)
                {
                    for (int i = 0; i < lstWOL.Count; i++)
                    {
                        string data = lstWOL[i].MAC + "," + lstWOL[i].NAME + "," + lstWOL[i].IP;
                        settingFile.WriteString("DATA", "W" + i, data);
                    }
                }
                else
                {
                    settingFile.EraseSection("DATA");
                }
            }
            catch
            { }

        }
        private void WOLPanel_Load(object sender, EventArgs e)
        {
            settingFile = new IniFiles(Application.StartupPath + "\\WOL\\WOL.ini");
            Load_Inifile();
        }

        public void WOL_Saved_default()
        {
            settingFile = new IniFiles(Application.StartupPath + "\\WOL\\WOL.ini");
            Save_Inifile();
        }
        #endregion
        /// <summary>
        /// 编辑修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Eidt_Click(object sender, EventArgs e)
        {
            if (dgWOL.SelectedRows.Count >= 0)
            {
                frmAWOL fCmd = new frmAWOL(lstWOL[dgWOL.SelectedRows[0].Index]);
                if (fCmd.ShowDialog() == DialogResult.OK)
                {
                    //lstWOL.Add(fCmd.NewWOL);
                    lstWOL[dgWOL.SelectedRows[0].Index] = fCmd.NewWOL;
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (lstWOL.Count <= 0)
            {
                MS_eidt.Enabled = false;
                MS_delete.Enabled = false;
                MS_wake.Enabled = false;
                //MS_Input.Enabled = false;
                MS_select.Enabled = false;
            }
            else
            {
                MS_eidt.Enabled = true;
                MS_delete.Enabled = true;
                MS_wake.Enabled = true;
                //.Enabled = true;
                MS_select.Enabled = true;
            }
        }

        bool all_select = false;
        private void MS_select_Click(object sender, EventArgs e)
        {
            if (all_select)
            {
                for (int i = 0; i < dgWOL.Rows.Count; i++)
                {
                    if ((Convert.ToBoolean(dgWOL.Rows[i].Cells[0].Value) == true))
                    {
                        dgWOL.Rows[i].Cells[0].Value = "False";
                    }
                    else
                        continue;
                }
                all_select = false;
            }
            else
            {
                for (int i = 0; i < dgWOL.Rows.Count; i++)
                {
                    if ((Convert.ToBoolean(dgWOL.Rows[i].Cells[0].Value) == false))
                    {
                        dgWOL.Rows[i].Cells[0].Value = "True";
                    }
                    else
                        continue;
                }
                all_select = true;
            }
        }
    }
}
