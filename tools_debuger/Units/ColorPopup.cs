using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace LeafSoft.Units
{
    public partial class ColorPopup : UserControl
    {
        private MainForm _main;
        private Configuration config;
        public ColorPopup(MainForm main)
        {
            InitializeComponent();
            _main = main;
            skinButton1.BackColor = Color.FromArgb(0xff, 84, 110, 122);
            skinButton2.BackColor = Color.FromArgb(0xff, 63, 81, 181);
            skinButton3.BackColor = Color.FromArgb(0xff, 67, 160, 71);
            skinButton4.BackColor = Color.FromArgb(0xff, 66, 66, 66);
            config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            _main.Change_ColorScheme(0);
            config.AppSettings.Settings["ColorIndex"].Value = "0";
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            _main.Change_ColorScheme(1);
            config.AppSettings.Settings["ColorIndex"].Value = "1";
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            _main.Change_ColorScheme(2);
            config.AppSettings.Settings["ColorIndex"].Value = "2";
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            _main.Change_ColorScheme(3);
            config.AppSettings.Settings["ColorIndex"].Value = "3";
        }
    }
}
