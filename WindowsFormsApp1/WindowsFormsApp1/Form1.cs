using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Management;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD.exe", "/K ipconfig | findstr /C:Address");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cleanmgr.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Taskmgr.exe");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("ncpa.cpl");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("dxdiag.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mmsys.cpl");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ms-settings:windowsupdate");
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (Tthen.AddSeconds(1.5) > DateTime.Now);
            System.Diagnostics.Process.Start("ms-settings:windowsupdate-action");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://go.microsoft.com/fwlink/?LinkId=691209");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ms-settings:privacy-backgroundapps");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ms-settings:appsfeatures");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("desk.cpl");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD.exe", "/C start explorer.exe %temp%");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nvidia.com/en-us/geforce/drivers/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.amd.com/en/support");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://i.postimg.cc/C1WNYRYQ/DDUSETTINGS.png");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.wagnardsoft.com/display-driver-uninstaller-ddu");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("diskmgmt.msc");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/C start dfrgui.exe");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ProcessStartInfo pi = new ProcessStartInfo("cmd.exe", "/K sfc /scannow");
            pi.Verb = "runas";
            pi.FileName = "cmd.exe";
            Process.Start(pi);
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            ProcessStartInfo pi = new ProcessStartInfo("cmd.exe", "/K DISM /Online /Cleanup-Image /RestoreHealth");
            pi.Verb = "runas";
            pi.FileName = "cmd.exe";
            Process.Start(pi);
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vulkan.lunarg.com/sdk/home#sdk/downloadConfirm/latest/windows/vulkan-runtime.exe");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.microsoft.com/en-us/download/confirmation.aspx?id=35");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.amd.com/en/support");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nvidia.com/en-us/geforce/drivers/");
        }
    }
    }