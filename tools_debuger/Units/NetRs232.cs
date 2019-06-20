﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using LeafSoft.Lib;

namespace LeafSoft.Units
{
    public partial class NetRs232 :UserControl, ICommunication
    {
        private SerialPort ComDevice = new SerialPort();

        private IniFiles settingFile;//配置文件
        public NetRs232()
        {
            InitializeComponent();

            settingFile = new IniFiles(Application.StartupPath + "\\IniFile\\setting.ini");
            drpComList.Items.Clear();
            drpComList.Items.AddRange(SerialPort.GetPortNames());
            if (drpComList.Items.Count > 0)
            {
                drpComList.SelectedIndex = 0;
                btnCom.Enabled = true;
            }
            drpBaudRate.SelectedIndex = 5;
            drpParity.SelectedIndex = 0;
            drpDataBits.SelectedIndex = 0;
            drpStopBits.SelectedIndex = 0;
            ComDevice.DataReceived+=new SerialDataReceivedEventHandler(Com_DataReceived);
        }

        /// <summary>
        /// 输出数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] ReDatas = new byte[ComDevice.BytesToRead];
            ComDevice.Read(ReDatas, 0, ReDatas.Length);//读取数据
            DataReceived(this,ReDatas);//输出数据
        }

        /// <summary>
        /// 串口打开/关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCom_Click(object sender, EventArgs e)
        {
            if (ComDevice.IsOpen==false)
            {
                ComDevice.PortName = drpComList.SelectedItem.ToString();
                ComDevice.BaudRate = Convert.ToInt32(drpBaudRate.SelectedItem.ToString());
                ComDevice.Parity = (Parity)Convert.ToInt32(drpParity.SelectedIndex.ToString());
                ComDevice.DataBits = Convert.ToInt32(drpDataBits.SelectedItem.ToString());
                ComDevice.StopBits = (StopBits)Convert.ToInt32(drpStopBits.SelectedItem.ToString());
                try
                {
                    ComDevice.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                btnCom.Text = "关闭串口";
                picComStatus.Image = Properties.Resources.greenlight;
            }
            else
            {
                try
                {
                    ComDevice.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnCom.Text = "打开串口";
                picComStatus.BackgroundImage = Properties.Resources.redlight;
            }

            drpComList.Enabled = !ComDevice.IsOpen;
            drpBaudRate.Enabled = !ComDevice.IsOpen;
            drpParity.Enabled = !ComDevice.IsOpen;
            drpDataBits.Enabled = !ComDevice.IsOpen;
            drpStopBits.Enabled = !ComDevice.IsOpen;
        }

        public event LeafEvent.DataReceivedHandler DataReceived;
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        public bool SendData(byte[] data)
        {
            if (ComDevice.IsOpen)
            {
                try
                {
                    ComDevice.Write(data, 0, data.Length);//发送数据
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        /// <summary>
        /// 关闭串口
        /// </summary>
        public void ClearSelf()
        {
            if (ComDevice.IsOpen)
            {
                ComDevice.Close();
            }
        }

        public void Init_ConfigCom()
        {
            string s = settingFile.ReadString("SETTING", "COM", "COM1");
            drpComList.SelectedIndex = drpComList.Items.IndexOf(s);
            s = settingFile.ReadString("SETTING", "Baud", "9600");
            drpBaudRate.SelectedIndex = drpBaudRate.Items.IndexOf(s);
            s = settingFile.ReadString("SETTING", "Parity", "None");
            drpParity.SelectedIndex = drpParity.Items.IndexOf(s);
            s = settingFile.ReadString("SETTING", "Data", "8");
            drpDataBits.SelectedIndex = drpDataBits.Items.IndexOf(s);
            s = settingFile.ReadString("SETTING", "Stop", "1");
            drpStopBits.SelectedIndex = drpStopBits.Items.IndexOf(s);
        }

        public void Save_ConfigCom()
        {
            settingFile.WriteString("SETTING", "COM", drpComList.Text);
            settingFile.WriteString("SETTING", "Baud", drpBaudRate.Text);
            settingFile.WriteString("SETTING", "Parity", drpParity.Text);
            settingFile.WriteString("SETTING", "Data", drpDataBits.Text);
            settingFile.WriteString("SETTING", "Stop", drpStopBits.Text);
        }
    }
}
