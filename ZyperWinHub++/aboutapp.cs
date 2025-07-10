using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZyperWinHub__
{
    public partial class aboutapp : UIForm
    {
        public aboutapp()
        {
            InitializeComponent();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://space.bilibili.com/1645147838");
        }
    }
}
