﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LeafSoft.Lib;
using System.Threading;

namespace LeafSoft.PartPanel
{
    public partial class AdbPanel : UserControl
    {
        //ADB命令窗口
        CmdHelp cmdHelp = new CmdHelp();

        delegate void SetTextCallback(string data);

        SynchronizationContext m_SyncContext = null;

        public AdbPanel()
        {
            InitializeComponent();
            m_SyncContext = SynchronizationContext.Current;
        }

        private void AdbPanel_Load(object sender, EventArgs e)
        {
            //注册事件
            CmdHelp.EventReceiveData += new CmdHelp.DelegateReceiveData(cmdHelp_EventReceiveData);
            CmdHelp.EventReceiveThreadData += new CmdHelp.DelegateReceiveThreadData(CmdHelp_EventReceiveThreadData);
            CmdHelp.EventReceiveThreadErrorData += new CmdHelp.DelegateReceiveThreadErrorData(CmdHelp_EventReceiveThreadErrorData);

            //加载所有的ADB指令
            LoadAllADBCmd();
        }

        //接收到数据
        private void cmdHelp_EventReceiveData(string data)
        {
            m_SyncContext.Post(setListData, data);

        }

        //接收错误数据
        private void CmdHelp_EventReceiveThreadErrorData(string data)
        {
            m_SyncContext.Post(setListData, data);
        }

        void CmdHelp_EventReceiveThreadData(string data)
        {
            m_SyncContext.Post(setListData, data);
        }

        //显示数据
        private void setListData(object data)
        {
            if (data != null)
            {
                txtListInfo.AppendText(">>:" + data + "\r\n");
            }
        }

        //加载所有的ADB指令
        private void LoadAllADBCmd()
        {
            cboAllADBCmd.Items.Clear();
            List<string> listAllADBInfo = CmdAdbInfo.GetAllADBCmdList();
            for (int i = 0; i < listAllADBInfo.Count; i++)
            {
                cboAllADBCmd.Items.Add(listAllADBInfo[i]);
            }
            if (cboAllADBCmd.Items.Count > 0)
            {
                cboAllADBCmd.SelectedIndex = 0;
            }
        }

        private void cboAllADBCmd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCustomCmd.Text = cboAllADBCmd.SelectedItem.ToString();
        }

        private void btnStartADB_Click(object sender, EventArgs e)
        {
            string cmdStr = CmdAdbInfo.adb_start_server;
            ShowSendCmdInfo(cmdStr);
            cmdHelp.SendAdbCmd(cmdStr);
        }

        private void btnStopADB_Click(object sender, EventArgs e)
        {
            string cmdStr = CmdAdbInfo.adb_kill_server;
            ShowSendCmdInfo(cmdStr);
            cmdHelp.SendAdbCmd(cmdStr);
        }

        private void btnADBVersion_Click(object sender, EventArgs e)
        {
            string cmdStr = CmdAdbInfo.adb_version;
            ShowSendCmdInfo(cmdStr);
            cmdHelp.SendAdbCmd(cmdStr);
        }

        private void btnGetDevice_Click(object sender, EventArgs e)
        {
            string cmdStr = CmdAdbInfo.adb_devices;
            ShowSendCmdInfo(cmdStr);
            string[] deviceInfo = cmdHelp.GetDevices(cmdStr);
            cboDevice.Items.Clear();
            for (int i = 0; i < deviceInfo.Length; i++)
            {
                cboDevice.Items.Add(deviceInfo[i]); ;
            }
            if (cboDevice.Items.Count > 0)
            {
                cboDevice.SelectedIndex = 0;
            }
        }

        private void cboDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            var deviceNo = Convert.ToString(cboDevice.SelectedItem);
            txtDeviceName.Text = string.Format("{0} {1}"
                            , cmdHelp.GetDeviceBrand(deviceNo)
                            , cmdHelp.GetDeviceModel(deviceNo));

            txtOS.Text = string.Format("Android {0} SDK:{1}"
                            , cmdHelp.GetDeviceVersionRelease(deviceNo)
                            , cmdHelp.GetDeviceVersionSdk(deviceNo));
        }

        private void btnSendCmd_Click(object sender, EventArgs e)
        {
            string cmdStr = txtCustomCmd.Text.Trim();
            ShowSendCmdInfo(cmdStr);
            cmdHelp.SendAdbCmd(cmdStr);
        }

        //显示发送的指令
        private void ShowSendCmdInfo(string cmdStr)
        {
            txtListInfo.AppendText("-->:" + cmdStr + "\r\n");
        }

        private void btnClearCmd_Click(object sender, EventArgs e)
        {
            txtListInfo.Clear();
        }
    }
}