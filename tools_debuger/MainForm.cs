using System.Windows.Forms;
using LeafSoft.LeafControl;
using System.Net;
using System.Threading;
using LeafSoft.Model;
using LeafSoft.PartPanel;
using EASkins;
using EASkins.Controls;
using System;
using PopupTool;
using System.Drawing;
using LeafSoft.Units;
using System.Configuration;

namespace LeafSoft
{
    public partial class MainForm : MaterialForm
    {
        #region primary
        private readonly MaterialSkinManager materialSkinManager;
        frmCheck fc = new frmCheck();
        frmBytes fb = new frmBytes();
        private Popup _pop;
        private ColorPopup _popControl;
        #endregion
        public MainForm()
        {
            InitializeComponent();

            int GID = Guid.NewGuid().ToString().Length;
            fc.TopMost = true;
            fb.TopMost = true;
            this.Text = Lib.AppInfor.AssemblyTitle + "[v" + Lib.AppInfor.AssemblyVersion + "][" + Lib.AppInfor.AssemblyCopyright + "][" + Lib.AppInfor.AssemblyCompany + "]";

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;           
            //Console.WriteLine(GID);
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey900, Primary.BlueGrey100, Accent.LightBlue200, TextShade.WHITE);
        }
        #region 主题背景
        private void materialRaisedButton1_Click(object sender, System.EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }

        //private int colorSchemeIndex;
        private void materialRaisedButton2_Click(object sender, System.EventArgs e)
        {
            _pop.Show(this, materialRaisedButton2.Location.X - 125, materialRaisedButton2.Location.Y + 36);
            /*
            colorSchemeIndex++;
            if (colorSchemeIndex > 3) colorSchemeIndex = 0;

            //These are just example color schemes
            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    break;
                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                    break;
                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                    break;
                case 3:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey700, Primary.Grey300, Accent.Orange100, TextShade.WHITE);
                    break;
            }
            */
        }

        public void Change_ColorScheme(int key)
        {
            try
            {
                switch (key)
                {
                    case 0:
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey900, Primary.BlueGrey100, Accent.LightBlue200, TextShade.WHITE);
                        break;
                    case 1:
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                        break;
                    case 2:
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                        break;
                    case 3:
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey700, Primary.Grey300, Accent.Orange100, TextShade.WHITE);
                        break;
                    default:
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void ClosePop()
        {
            _pop.Close();
        }

        #endregion
        #region 折叠控制
        bool size = false;
        private void naviBar1_Resize(object sender, System.EventArgs e)
        {
            //Console.WriteLine("====" + naviBar1.Width);
            if (!size && naviBar1.Width == 33)
            {
                materialTabControl1.Width += 125;
                materialTabControl1.Location = new System.Drawing.Point(materialTabControl1.Location.X - 125, materialTabControl1.Location.Y);
                size = true;
            }
            else if (size && naviBar1.Width == 158)
            {
                materialTabControl1.Width -= 125;
                materialTabControl1.Location = new System.Drawing.Point(materialTabControl1.Location.X + 125, materialTabControl1.Location.Y);
                size = false;
            }
        }
        #endregion
        #region 计算器
        private void materialFlatButton_crc_Click(object sender, EventArgs e)
        {
            if (fc.IsDisposed == true)
            {
                fc = new frmCheck();
                fc.TopMost = true;
            }
            fc.Show();
        }

        private void materialFlatButton_num_Click(object sender, EventArgs e)
        {
            if (fb.IsDisposed == true)
            {
                fb = new frmBytes();
                fb.TopMost = true;
            }
            fb.Show();
        }
        #endregion
        #region 调试窗口
        /// <summary>
        /// 新建调试窗口
        /// </summary>
        /// <param name="p"></param>
        /// <param name="title"></param>
        /// <param name="icon"></param>
        private void CreateNewTest(object p, string title, Icon icon)
        {
            Form frm = new Form();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Icon = icon;
            frm.Controls.Add((Control)p);
            frm.Width = 800;
            frm.Height = 500;
            frm.ShowIcon = true;
            frm.Text = title;
            frm.FormClosing += new FormClosingEventHandler(frm_FormClosing);
            frm.Show();
        }

        void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = (Form)sender;
            PartPanel.BasePanel bp = (PartPanel.BasePanel)frm.Controls[0];
            bp.ClearSelf();
        }

        private void materialFlatButton_srai_Click(object sender, EventArgs e)
        {
            ComPanel tp = new ComPanel();
            tp.Dock = DockStyle.Fill;
            CreateNewTest(tp, "串口[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.com1);
        }

        private void materialFlatButton_tcps_Click(object sender, EventArgs e)
        {
            TCPServerPanel nwin = new TCPServerPanel();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "TCP Server[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.tcp);
        }

        private void materialFlatButton_tcpc_Click(object sender, EventArgs e)
        {
            TCPClientPanel nwin = new TCPClientPanel();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "TCP Client[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.tcp);
        }

        private void materialFlatButton_udps_Click(object sender, EventArgs e)
        {
            UDPServerPanel nwin = new UDPServerPanel();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "UDP Server[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.udp);
        }

        private void materialFlatButton_udpc_Click(object sender, EventArgs e)
        {
            UDPClientPanel nwin = new UDPClientPanel();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "UDP Client[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.udp);
        }
        #endregion
        #region 监视窗口
        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            SocketMonitor nwin = new SocketMonitor();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "Socket通信监视器[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.monitor_socket_icon);
        }

        #endregion
        #region 关于
        private void naviBand4_Click(object sender, EventArgs e)
        {
            new AboutMe().ShowDialog();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            new AboutMe().ShowDialog();
        }
        #endregion
        #region Load
        /// <summary>
        /// 初始化加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string key = config.AppSettings.Settings["ColorIndex"].Value;
            Change_ColorScheme(int.Parse(key));
            _popControl = new ColorPopup(this);
            _pop = new Popup(_popControl);
        }

        #endregion
    }
}
