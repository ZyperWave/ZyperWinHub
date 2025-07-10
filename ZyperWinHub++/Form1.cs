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
    public partial class MainWindow : UIForm
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(".\\Tools\\关闭Defender工具\\Defender_Control.exe");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start(".\\Tools\\Windows 轻松设置\\Windows11轻松设置.exe");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start(".\\Tools\\Winhance\\Winhance.exe");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start(".\\Tools\\Dism++\\Dism++x86.exe");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start(".\\Tools\\服务项优化工具\\eso.exe");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Process.Start(".\\Tools\\驱动安装工具\\驱动总裁.exe");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start(".\\Tools\\驱动安装工具\\360驱动大师.exe");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Process.Start(".\\Tools\\Windows 右键管理\\ContextMenuManager.NET.4.0.exe");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Process.Start(".\\Tools\\卸载工具\\geek.exe");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Process.Start(".\\Tools\\GodMode.{ED7BA470-8E54-465E-825C-99712043E01C}");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bilibili.com/opus/1054761358514454535");
        }


        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Process.Start("https://ZyperWave.github.io");
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            aboutapp f = new aboutapp();
            f.ShowDialog();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown -r -t 1");
        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://otp.landian.vip/zh-cn/");
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://pan.huang1111.cn/s/BGD8nf6?");
        }

        private void pictureBox14_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://jldzz.cn/");
        }
    }
}
