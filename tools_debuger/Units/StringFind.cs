using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeafSoft.Units
{
    public partial class StringFind : UserControl
    {
        private DataReceive dr;
        public StringFind(DataReceive DR)
        {
            InitializeComponent();
            dr = DR;
        }


        private void close_Click(object sender, EventArgs e)
        {
            dr.ClosePop();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            dr.FindString(Tofindstr.Text);
        }
    }
}
