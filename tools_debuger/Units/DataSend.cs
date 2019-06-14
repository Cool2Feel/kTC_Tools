using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using LeafSoft.Lib;
using System.Threading;
using System.IO;

namespace LeafSoft.Units
{
    public partial class DataSend : UserControl
    {
        BindingList<Model.CMD> lstCMD = new BindingList<Model.CMD>();
        private IniFiles settingFile;//配置文件

        public event LeafEvent.DataSendHandler EventDataSend;

        /// <summary>
        /// 是否在自动循环发送状态
        /// </summary>
        bool AutoSend = false;

        public DataSend()
        {
            InitializeComponent();

            dgCMD.AutoGenerateColumns = false;
            lstCMD.Add(new Model.CMD(EnumType.DataEncode.ASCII, new ASCIIEncoding().GetBytes("Test!")));
            dgCMD.DataSource = lstCMD;
            //byte[] data = new byte[] { 0xFF, 0xFD, 0x18, 0x0D };
            //lstCMD.Add(new Model.CMD(EnumType.DataEncode.Hex, data));
        }

        private void dgCMD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex>=0)
            {//点击了发送按钮 
                if (EventDataSend != null)
                {
                    if (EventDataSend(lstCMD[e.RowIndex].Bytes) == false)
                    {
                        StopAutoSend();
                    }
                    else
                    {
                        lblCount.Invoke(new MethodInvoker(delegate
                        {
                            lblCount.Text = (int.Parse(lblCount.Text) + lstCMD[e.RowIndex].Bytes.Length).ToString();
                        }));
                    }
                }

            }
        }

        private void dgCMD_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgCMD.Rows[e.RowIndex].Cells[3].Value = "发送";
        }

        /// <summary>
        /// 添加调试命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_Add_Click(object sender, EventArgs e)
        {
            frmCMD fCmd = new frmCMD();
            if (fCmd.ShowDialog() == DialogResult.OK)
            {
                lstCMD.Add(fCmd.NewCMD);
            }
        }

        /// <summary>
        /// 编辑调试命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_Edit_Click(object sender, EventArgs e)
        {
            if (dgCMD.SelectedRows.Count > 0)
            {
                frmCMD fCmd = new frmCMD(lstCMD[dgCMD.SelectedRows[0].Index]);
                if (fCmd.ShowDialog() == DialogResult.OK)
                {
                    lstCMD[dgCMD.SelectedRows[0].Index] = fCmd.NewCMD;
                }
            }
        }

        /// <summary>
        /// 删除调试命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_Delete_Click(object sender, EventArgs e)
        {
            if (dgCMD.SelectedRows.Count > 0)
            {
                lstCMD.RemoveAt(dgCMD.SelectedRows[0].Index);
            }
        }

        /// <summary>
        /// 自动发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutoSend_Click(object sender, EventArgs e)
        {
            if (AutoSend == false)
            {
                btnAutoSend.Text = "停止循环";
                dgCMD.Enabled = false;
                nmDelay.Enabled = false;
                AutoSend = true;
                Thread ThTestL = new Thread(new ParameterizedThreadStart(TAutoSend));
                ThTestL.IsBackground = true;
                ThTestL.Start(nmDelay.Value);
            }
            else
            {
                StopAutoSend();
            }
        }

        /// <summary>
        /// 自动发送命令线程
        /// </summary>
        private void TAutoSend(object Interval)
        {
            try
            {
                object sendlock = new object();
                int SendInterval = Convert.ToInt32(Interval);
                while (AutoSend)
                {
                    for (int i = 0; i < lstCMD.Count; i++)
                    {
                        if (AutoSend)
                        {
                            this.Invoke(new MethodInvoker(delegate
                            {
                                object cbxValue = dgCMD.Rows[i].Cells[0].Value;
                                if (cbxValue is bool && cbxValue.Equals(true))
                                {
                                    if (EventDataSend != null)
                                    {
                                        if (EventDataSend(lstCMD[i].Bytes) == false)
                                        {
                                            StopAutoSend();
                                        }
                                        else
                                        {
                                            lblCount.Invoke(new MethodInvoker(delegate
                                            {
                                                lblCount.Text = (int.Parse(lblCount.Text) + lstCMD[i].Bytes.Length).ToString();
                                            }));
                                        }
                                    }
                                }
                            }));
                            Thread.Sleep(SendInterval);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            catch { };
        }

        /// <summary>
        /// 停止循环发送
        /// </summary>
        private void StopAutoSend()
        {
            AutoSend = false;
            btnAutoSend.Text = "循环发送";
            dgCMD.Enabled = true;
            nmDelay.Enabled = true;
        }

        private void lblCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblCount.Text = "0";
        }

        private string SetType(EnumType.DataEncode EncodeType)
        {
            string ss = "";
            switch (EncodeType)
            {
                case EnumType.DataEncode.Hex:
                    ss = "H";
                    break;
                case EnumType.DataEncode.ASCII:
                    ss = "A";
                    break;
                case EnumType.DataEncode.UTF8:
                    ss = "U";
                    break;
                case EnumType.DataEncode.GB2312:
                    ss = "G";
                    break;
                default:
                    ss = "H";
                    break;
            }
            return ss;
        }

        private EnumType.DataEncode GetType(string key)
        {
            EnumType.DataEncode EncodeType = EnumType.DataEncode.Hex;
            switch (key)
            {
                case "H":
                    EncodeType = EnumType.DataEncode.Hex;
                    break;
                case "A":
                    EncodeType = EnumType.DataEncode.ASCII;
                    break;
                case "U":
                    EncodeType = EnumType.DataEncode.UTF8;
                    break;
                case "G":
                    EncodeType = EnumType.DataEncode.GB2312;
                    break;
                default:
                    EncodeType = EnumType.DataEncode.Hex;
                    break;
            }
            return EncodeType;
        }

        private void Load_Inifile()
        {
            try
            {
                string s = settingFile.ReadString("SETTING", "COM", "COM1");

                int count = settingFile.ReadInteger("SETTING", "COUNT", 0);
                lstCMD.Clear();
                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        string data = settingFile.ReadString("DATA", "N" + i, "");
                        if (!data.Equals(""))
                        {
                            string[] str = data.Split(',');
                            EnumType.DataEncode Type = GetType(str[0]);
                            //byte[] byteArray = Encoding.Default.GetBytes(str[1]);
                            lstCMD.Add(new Model.CMD(Type, str[1]));
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
                if (lstCMD.Count > 0)
                {
                    settingFile.WriteInteger("SETTING", "COUNT", lstCMD.Count);
                    for (int i = 0; i < lstCMD.Count; i++)
                    {
                        string type = SetType(lstCMD[i].ContentType);
                        string cmd = lstCMD[i].Text;
                        string data = type + "," + cmd;
                        settingFile.WriteString("DATA", "N" + i, data);
                    }
                }
            }
            catch
            { }
            
        }

        private void DataSend_Load(object sender, EventArgs e)
        {
            string sPath = Application.StartupPath + "\\IniFile";
            if (!Directory.Exists(sPath))
            {
                Directory.CreateDirectory(sPath);
            }
            settingFile = new IniFiles(Application.StartupPath + "\\IniFile\\setting.ini");
            Load_Inifile();
        }

        private void MS_Saved_Click(object sender, EventArgs e)
        {
            settingFile = new IniFiles(Application.StartupPath + "\\IniFile\\setting.ini");
            Save_Inifile();
        }

        private void MS_Input_Click(object sender, EventArgs e)
        {
            openFileRead.InitialDirectory = Application.StartupPath + "\\IniFile";
            openFileRead.Filter = "命令文件|*.ini";
            openFileRead.FilterIndex = 1;
            openFileRead.RestoreDirectory = true;
            if (openFileRead.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileRead.FileName;
                //Console.WriteLine(filename);
                settingFile = new IniFiles(filename);
                Load_Inifile();
            }
        }

        private void MS_SaveAs_Click(object sender, EventArgs e)
        {
            saveFileInit.InitialDirectory = Application.StartupPath + "\\IniFile";
            saveFileInit.Filter = "命令文件|*.ini";
            saveFileInit.FilterIndex = 1;
            saveFileInit.RestoreDirectory = true;
            saveFileInit.AddExtension = true;
            if (saveFileInit.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileInit.FileName;
                //Console.WriteLine(filename);
                settingFile = new IniFiles(filename);

                Save_Inifile();
            }
            //settingFile = new IniFiles(Application.StartupPath + "\\IniFile\\setting.ini");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(lstCMD.Count < 0)
            {
                MS_Edit.Enabled = false;
                MS_Delete.Enabled = false;
                MS_Saved.Enabled = false;
                MS_Input.Enabled = false;
                MS_SaveAs.Enabled = false;
            }
            else
            {
                MS_Edit.Enabled = true;
                MS_Delete.Enabled = true;
                MS_Saved.Enabled = true;
                MS_Input.Enabled = true;
                MS_SaveAs.Enabled = true;
            }
        }
    }
}
